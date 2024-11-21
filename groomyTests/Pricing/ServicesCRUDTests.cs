using Google.Cloud.Firestore;
using groomy.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace groomy.Pricing.Tests
{
    [TestClass()]
    public class ServicesCRUDTests
    {

        private FirestoreDb db;

        private ServicesCRUD servicesCRUD;


        [TestInitialize]

        public void Initialize()

        {

            db = firebaseConfig.Instance.getFirestoreDB();

            servicesCRUD = new ServicesCRUD(db, "Services");

        }


        [TestMethod()]

        public async Task CreateServiceTest()

        {

            Service addService = new Service() { Name = "Test Service", Desc = "This is a test service.", Price = 99.99 };

            await servicesCRUD.CreateService(addService);

            Assert.IsNotNull(addService.Id); // Ensure the service ID is set

        }


        [TestMethod()]

        public async Task GetServiceTest()

        {

            // Arrange

            Service addService = new Service() { Name = "Test Service", Desc = "This is a test service.", Price = 99.99 };

            await servicesCRUD.CreateService(addService);


            // Act

            Service service = await servicesCRUD.GetService(addService.Id);


            // Assert

            Assert.IsNotNull(service);

            Assert.AreEqual(addService.Name, service.Name);

            Assert.AreEqual(addService.Desc, service.Desc);

            Assert.AreEqual(addService.Price, service.Price);

        }


        [TestMethod()]

        public async Task SoftDeleteServiceTest()

        {

            // Arrange

            Service addService = new Service() { Name = "Test Service", Desc = "This is a test service.", Price = 99.99 };

            await servicesCRUD.CreateService(addService);


            // Act

            await servicesCRUD.SoftDeleteService(addService.Id);

            Service deletedService = await servicesCRUD.GetService(addService.Id);


            // Assert

            Assert.IsNotNull(deletedService);
            Console.WriteLine(deletedService.Deleted);
            Assert.IsTrue(deletedService.Deleted); // Check if the service is marked as deleted

        }


        [TestMethod()]

        public async Task UpdateServiceTest()

        {

            // Arrange

            Service addService = new Service() { Name = "Test Service", Desc = "This is a test service.", Price = 99.99 };

            await servicesCRUD.CreateService(addService);


            Service updatedService = new Service

            {

                Id = addService.Id, // Make sure to set the ID for the update

                Name = "Updated Service",

                Desc = "This is an updated service description.",

                Price = 149.99

            };


            // Act

            await servicesCRUD.UpdateService(updatedService);

            Service service = await servicesCRUD.GetService(addService.Id);


            // Assert

            Assert.IsNotNull(service);

            Assert.AreEqual(updatedService.Name, service.Name);

            Assert.AreEqual(updatedService.Desc, service.Desc);

            Assert.AreEqual(updatedService.Price, service.Price);

        }


        [TestMethod()]

        public async Task GetAllServicesTest()

        {

            // Arrange

            Service service1 = new Service { Name = "Service One", Desc = "This is the first service.", Price = 50.00 };

            Service service2 = new Service { Name = "Service Two", Desc = "This is the second service.", Price = 75.00 };


            await servicesCRUD.CreateService(service1);

            await servicesCRUD.CreateService(service2);


            // Act

            List<Service> allServices = await servicesCRUD.GetAllServices();


            // Assert

            Assert.IsNotNull(allServices);

            Assert.IsTrue(allServices.Any(s => s.Name == service1.Name && s.Desc == service1.Desc && s.Price == service1.Price));

            Assert.IsTrue(allServices.Any(s => s.Name == service2.Name && s.Desc == service2.Desc && s.Price == service2.Price));

        }
    }
}