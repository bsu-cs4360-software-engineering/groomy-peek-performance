using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using Moq;
using groomy.services;

namespace groomy.Customers.Tests
{
    [TestClass()]
    public class customerCRUDTests
    {
        public firebaseConfig __config = firebaseConfig.Instance;
        [TestMethod()]
        public async Task getAllCustomerTest_ReturnsListOfCustomers()
        {
            FirestoreDb __db = __config.getFirestoreDB();
            customerCRUD testCustCrud = new customerCRUD(__db);
            
            var customersQuestionMark = await testCustCrud.getAllCustomers();
            Assert.IsNotNull(customersQuestionMark);
            
        }

        [TestMethod()]
        public async Task addCustomerAsyncTest()
        {
            FirestoreDb __db = __config.getFirestoreDB();
            customerCRUD testCustCrud = new customerCRUD(__db);
            customer newCustomer = new customer
            {
                email = "john.doe@example.com",
                fName = "John",
                lName = "Doe",
                id = "1",
                deleted = false,
                phoneNumber = "123-456-7890",
                address = "123 Main St, Anytown, USA"
            };
            await testCustCrud.addCustomerAsync(newCustomer);
            var z = testCustCrud.getCustomerByEmail("john.doe@example.com");
            Console.WriteLine(z);
            Assert.IsNotNull(z);
        }

        [TestMethod()]
        public async Task deleteCustomerByIDTest()
        {
            FirestoreDb __db = __config.getFirestoreDB();
            customerCRUD testCustCrud = new customerCRUD(__db);
            await testCustCrud.deleteCustomerByEmail("john.doe@example.com");
            
        }

        [TestMethod()]
        public async Task updateCustomerTest()
        {
            // Arrange
            FirestoreDb __db = __config.getFirestoreDB();
            customerCRUD testCustCrud = new customerCRUD(__db);

            // Create and add a new customer
            customer newCustomer = new customer
            {
                email = "jane.doe@example.com",
                fName = "Jane",
                lName = "Doe",
                deleted = false,
                phoneNumber = "987-654-3210",
                address = "456 Elm St, Anytown, USA"
            };

            await testCustCrud.addCustomerAsync(newCustomer);

            // Now retrieve the customer by email to get the document ID
            // After adding the customer

            var addedCustomer = await testCustCrud.getCustomerByEmail("jane.doe@example.com");

            Assert.IsNotNull(addedCustomer, "Customer should be added successfully.");

            Console.WriteLine($"Added Customer ID: {addedCustomer.id}"); // Debugging line


            // Modify the customer object

            addedCustomer.phoneNumber = "111-222-3333"; // Update phone number

            addedCustomer.address = "789 Oak St, Anytown, USA"; // Update address


            // Act

            await testCustCrud.updateCustomer(addedCustomer);


            // Retrieve the updated customer

            var updatedCustomer = await testCustCrud.getCustomerById(addedCustomer.id);

            Console.WriteLine($"Updated Customer ID: {updatedCustomer.id}");
        }
    }
}