using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Google.Cloud.Firestore;

namespace groomy.services.Tests
{

    [TestClass()]
    public class FirebaseConfigTests
    {
       
        [TestMethod()]
        public void TestInitializeFirebaseSetsDefaultInstance()
        {
            // Arrange
            var config = FirebaseConfig.Instance;
            // Assert
            Assert.IsNotNull(config);
        }
        [TestMethod()]
        public void getFirestoreDBTest_IsNotNull()
        {
            FirebaseConfig config = FirebaseConfig.Instance;
            var data = config.getFirestoreDB();
            Assert.IsNotNull(data);
        }
        [TestMethod()]
        public void getFirestoreDBTest_CorrectTypeFirestoreDb_ReturnsTrue()
        {
            FirebaseConfig config = FirebaseConfig.Instance;
            var data = config.getFirestoreDB();
            Assert.IsInstanceOfType(data, typeof(FirestoreDb));
        }
        [TestMethod()]
        public void getFirestoreDBTest_IsNotDuplicated_ReturnsTrue()
        {
            FirebaseConfig config = FirebaseConfig.Instance;
            FirebaseConfig config2 = FirebaseConfig.Instance;

            var data = config.getFirestoreDB();
            Assert.AreSame(config,config2);
        }
    }
}