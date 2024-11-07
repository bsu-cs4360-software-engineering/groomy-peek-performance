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

            var customersQuestionMark = await testCustCrud.getAllCustomers();
            Assert.IsNotNull(customersQuestionMark);
            
        }

        [TestMethod()]
        public void getAllCustomersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addCustomerAsyncTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getCustomerByIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getCustomerByEmailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void updateCustomerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteCustomerByIDTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void customerCRUDTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getAllCustomersTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void addCustomerAsyncTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getCustomerByIdTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getCustomerByEmailTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void getDocumentIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void updateCustomerTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void deleteCustomerByIDTest1()
        {
            Assert.Fail();
        }
    }
}