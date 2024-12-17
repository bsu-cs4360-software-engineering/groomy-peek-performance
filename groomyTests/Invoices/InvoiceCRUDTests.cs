using Microsoft.VisualStudio.TestTools.UnitTesting;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using groomy.services;

namespace groomy.Invoices.Tests
{
    [TestClass]
    public class InvoiceCRUDTests
    {
        private FirestoreDb _db;
        private InvoiceCRUD _invoiceCrud;
        private string _testCollectionName = "TestInvoices";
        private List<string> _createdInvoiceIds;

        [TestInitialize]
        public void Setup()
        {
            _db = firebaseConfig.Instance.getFirestoreDB();
            _invoiceCrud = new InvoiceCRUD(_db, _testCollectionName);
            _createdInvoiceIds = new List<string>();
        }

        [TestCleanup]
        public async Task Cleanup()
        {
            foreach (var id in _createdInvoiceIds)
            {
                var docRef = _db.Collection(_testCollectionName).Document(id);
                await docRef.DeleteAsync();
            }
            _createdInvoiceIds.Clear();
        }

        private Invoice CreateTestInvoice(string clientId = "test-client", bool isPaid = false)
        {
            return new Invoice
            {
                ClientId = clientId,
                DueDate = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(30)),
                IsPaid = isPaid,
                LineItems = new List<LineItem>
                {
                    new LineItem
                    {
                        ServiceId = "service-1",
                        ServiceName = "Test Service 1",
                        Cost = 50.00,
                        Quantity = 1
                    },
                    new LineItem
                    {
                        ServiceId = "service-2",
                        ServiceName = "Test Service 2",
                        Cost = 25.00,
                        Quantity = 2
                    }
                }
            };
        }

        private async Task<string> CreateAndTrackTestInvoice(Invoice invoice)
        {
            await _invoiceCrud.CreateInvoice(invoice);
            _createdInvoiceIds.Add(invoice.Id);
            return invoice.Id;
        }

        [TestMethod]
        public async Task CreateInvoice_ShouldCreateInvoiceWithCorrectData()
        {
            var invoice = CreateTestInvoice();
            await _invoiceCrud.CreateInvoice(invoice);
            _createdInvoiceIds.Add(invoice.Id);

            Assert.IsNotNull(invoice.Id);
            Assert.IsNotNull(invoice.CreatedDate);
            Assert.AreEqual(100.00, invoice.Total);
            Assert.IsFalse(invoice.Deleted);
        }

        [TestMethod]
        public async Task GetInvoice_ShouldReturnCorrectInvoice()
        {
            var invoice = CreateTestInvoice();
            await CreateAndTrackTestInvoice(invoice);

            var retrievedInvoice = await _invoiceCrud.GetInvoice(invoice.Id);

            Assert.IsNotNull(retrievedInvoice);
            Assert.AreEqual(invoice.Id, retrievedInvoice.Id);
            Assert.AreEqual(invoice.Total, retrievedInvoice.Total);
            Assert.AreEqual(invoice.ClientId, retrievedInvoice.ClientId);
        }

        [TestMethod]
        public async Task GetAllInvoices_ShouldReturnActiveInvoices()
        {
            var initialInvoices = await _invoiceCrud.GetAllInvoices();
            var initialCount = initialInvoices.Count;

            var invoice1 = CreateTestInvoice("client-1");
            var invoice2 = CreateTestInvoice("client-2");
            await CreateAndTrackTestInvoice(invoice1);
            await CreateAndTrackTestInvoice(invoice2);

            var allInvoices = await _invoiceCrud.GetAllInvoices();

            Assert.AreEqual(initialCount + 2, allInvoices.Count);
            Assert.IsTrue(allInvoices.Any(i => i.Id == invoice1.Id));
            Assert.IsTrue(allInvoices.Any(i => i.Id == invoice2.Id));
            Assert.IsTrue(allInvoices.All(i => !i.Deleted));
        }

        [TestMethod]
        public async Task GetPaidInvoices_ShouldReturnOnlyPaidInvoices()
        {
            var paidInvoice = CreateTestInvoice("client-paid", true);
            var unpaidInvoice = CreateTestInvoice("client-unpaid", false);
            await CreateAndTrackTestInvoice(paidInvoice);
            await CreateAndTrackTestInvoice(unpaidInvoice);

            var paidInvoices = await _invoiceCrud.GetPaidInvoices();

            Assert.IsTrue(paidInvoices.All(i => i.IsPaid));
            Assert.IsTrue(paidInvoices.Any(i => i.Id == paidInvoice.Id));
            Assert.IsFalse(paidInvoices.Any(i => i.Id == unpaidInvoice.Id));
        }

        [TestMethod]
        public async Task GetUnPaidInvoices_ShouldReturnOnlyUnpaidInvoices()
        {
            var paidInvoice = CreateTestInvoice("client-paid", true);
            var unpaidInvoice = CreateTestInvoice("client-unpaid", false);
            await CreateAndTrackTestInvoice(paidInvoice);
            await CreateAndTrackTestInvoice(unpaidInvoice);

            var unpaidInvoices = await _invoiceCrud.GetUnPaidInvoices();

            Assert.IsTrue(unpaidInvoices.All(i => !i.IsPaid));
            Assert.IsTrue(unpaidInvoices.Any(i => i.Id == unpaidInvoice.Id));
            Assert.IsFalse(unpaidInvoices.Any(i => i.Id == paidInvoice.Id));
        }

        [TestMethod]
        public async Task UpdateInvoice_ShouldUpdateCorrectly()
        {
            var invoice = CreateTestInvoice();
            await CreateAndTrackTestInvoice(invoice);

            invoice.IsPaid = true;
            invoice.LineItems.Add(new LineItem
            {
                ServiceId = "service-3",
                ServiceName = "Test Service 3",
                Cost = 30.00,
                Quantity = 1
            });

            await _invoiceCrud.UpdateInvoice(invoice);
            var updatedInvoice = await _invoiceCrud.GetInvoice(invoice.Id);

            Assert.IsTrue(updatedInvoice.IsPaid);
            Assert.AreEqual(130.00, updatedInvoice.Total);
            Assert.AreEqual(3, updatedInvoice.LineItems.Count);
        }

        [TestMethod]
        public async Task SoftDeleteInvoice_ShouldMarkAsDeleted()
        {
            var invoice = CreateTestInvoice();
            await CreateAndTrackTestInvoice(invoice);

            await _invoiceCrud.SoftDeleteInvoice(invoice.Id);
            var deletedInvoice = await _invoiceCrud.GetInvoice(invoice.Id);

            Assert.IsNull(deletedInvoice);
        }
    }
}