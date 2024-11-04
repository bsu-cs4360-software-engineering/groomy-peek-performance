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
        private Mock<FirestoreDb> _mockDb;

        private customerCRUD _customerCRUD;
        [TestMethod()]
        public void customerCRUDTest()
        {
            customer newCustomer = new customer
            {
                email = "john.doe@example.com",
                fName = "John",
                lName = "Doe",
                id = 1,
                deleted = false,
                phoneNumber = "123-456-7890",
                address = "123 Main St, Anytown, USA"
            };
        }

        [TestMethod()]
        public void getAllCustomersTest()
        {
            var z = _customerCRUD.getAllCustomers();
            if(z != null)
            {
                Assert.IsNotNull(z);
            }
            else
            { Assert.Fail(); }
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
    }
}