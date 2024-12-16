using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Invoices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using groomy.services;

namespace groomy.Invoices.Tests
{
    [TestClass()]
    public class InvoiceCRUDTests
    {
        public firebaseConfig __config = firebaseConfig.Instance;

        [TestMethod()]
        public async Task CreateInvoiceTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Create a test invoice
            Invoice newInvoice = new Invoice
            {
                ClientId = "test-client-123",
                InvoiceNumber = "INV-2024-001",
                DueDate = DateTime.UtcNow.AddDays(30),
                IsPaid = false,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ServiceId = "service-1",
                        ServiceName = "Dog Grooming",
                        Cost = 50.00,
                        Quantity = 1,
                        ServiceDate = DateTime.UtcNow
                    },
                    new LineItem
                    {
                        ServiceId = "service-2",
                        ServiceName = "Nail Trim",
                        Cost = 15.00,
                        Quantity = 1,
                        ServiceDate = DateTime.UtcNow
                    }
                }
            };

            // Act
            await testInvoiceCrud.CreateInvoice(newInvoice);

            // Assert
            Assert.IsNotNull(newInvoice.Id, "Invoice ID should be generated");
            Assert.AreEqual(65.00, newInvoice.Total, "Total should be calculated correctly");
            Assert.IsFalse(newInvoice.Deleted, "New invoice should not be deleted");
            Assert.IsNotNull(newInvoice.CreatedDate, "Created date should be set");
        }

        [TestMethod()]
        public async Task GetInvoiceTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Create a test invoice first
            Invoice newInvoice = new Invoice
            {
                ClientId = "test-client-456",
                InvoiceNumber = "INV-2024-002",
                DueDate = DateTime.UtcNow.AddDays(30),
                IsPaid = false,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ServiceId = "service-3",
                        ServiceName = "Bath",
                        Cost = 40.00,
                        Quantity = 1,
                        ServiceDate = DateTime.UtcNow
                    }
                }
            };

            await testInvoiceCrud.CreateInvoice(newInvoice);

            // Act
            var retrievedInvoice = await testInvoiceCrud.GetInvoice(newInvoice.Id);

            // Assert
            Assert.IsNotNull(retrievedInvoice, "Invoice should be retrieved");
            Assert.AreEqual(newInvoice.Id, retrievedInvoice.Id, "Retrieved invoice ID should match");
            Assert.AreEqual(newInvoice.ClientId, retrievedInvoice.ClientId, "Client ID should match");
        }

        [TestMethod()]
        public async Task UpdateInvoiceTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Create a test invoice
            Invoice newInvoice = new Invoice
            {
                ClientId = "test-client-789",
                InvoiceNumber = "INV-2024-003",
                DueDate = DateTime.UtcNow.AddDays(30),
                IsPaid = false,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ServiceId = "service-4",
                        ServiceName = "Haircut",
                        Cost = 60.00,
                        Quantity = 1,
                        ServiceDate = DateTime.UtcNow
                    }
                }
            };

            await testInvoiceCrud.CreateInvoice(newInvoice);

            // Modify the invoice
            newInvoice.IsPaid = true;
            newInvoice.LineItems.Add(new LineItem
            {
                ServiceId = "service-5",
                ServiceName = "Additional Service",
                Cost = 25.00,
                Quantity = 1,
                ServiceDate = DateTime.UtcNow
            });

            // Act
            await testInvoiceCrud.UpdateInvoice(newInvoice);

            // Retrieve and verify
            var updatedInvoice = await testInvoiceCrud.GetInvoice(newInvoice.Id);

            // Assert
            Assert.IsTrue(updatedInvoice.IsPaid, "Invoice should be marked as paid");
            Assert.AreEqual(85.00, updatedInvoice.Total, "Total should be recalculated");
            Assert.AreEqual(2, updatedInvoice.LineItems.Count, "Line items should be updated");
        }

        [TestMethod()]
        public async Task SoftDeleteInvoiceTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Create a test invoice
            Invoice newInvoice = new Invoice
            {
                ClientId = "test-client-101",
                InvoiceNumber = "INV-2024-004",
                DueDate = DateTime.UtcNow.AddDays(30),
                IsPaid = false,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ServiceId = "service-6",
                        ServiceName = "Full Grooming",
                        Cost = 75.00,
                        Quantity = 1,
                        ServiceDate = DateTime.UtcNow
                    }
                }
            };

            await testInvoiceCrud.CreateInvoice(newInvoice);

            // Act
            await testInvoiceCrud.SoftDeleteInvoice(newInvoice.Id);

            // Retrieve and verify
            var deletedInvoice = await testInvoiceCrud.GetInvoice(newInvoice.Id);

            // Assert
            Assert.IsNull(deletedInvoice, "Soft-deleted invoice should not be retrievable");
        }

        [TestMethod()]
        public async Task GetAllInvoicesTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Act
            var allInvoices = await testInvoiceCrud.GetAllInvoices();

            // Assert
            Assert.IsNotNull(allInvoices, "Should return a list of invoices");
            Assert.IsTrue(allInvoices.Count > 0, "Should have at least one invoice");
        }

        [TestMethod()]
        public async Task GetUnpaidInvoicesTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            InvoiceCRUD testInvoiceCrud = new InvoiceCRUD(__db);

            // Act
            var unpaidInvoices = await testInvoiceCrud.GetUnpaidInvoices();

            // Assert
            Assert.IsNotNull(unpaidInvoices, "Should return a list of unpaid invoices");
            Assert.IsTrue(unpaidInvoices.All(inv => !inv.IsPaid), "All invoices should be unpaid");
        }
    }
}