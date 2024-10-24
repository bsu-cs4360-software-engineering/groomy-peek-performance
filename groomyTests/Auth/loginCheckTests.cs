using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using groomy.services; 

namespace groomy.Auth.Tests
{
    [TestClass()]
    public class loginCheckTests
    {
        [TestMethod()]
        public async Task loginCheckTest_CorrectCredentials_ReturnsTrue()
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb __database = config.getFirestoreDB();
            var user = new adminUser
            {
                email = "admin@example.com",
                fName = "John",
                lName = "Doe",
                password = "password123"
            };
            user.password = BCrypt.Net.BCrypt.HashPassword(user.password);

            // Get the document reference and set the user data
            DocumentReference docRef = __database.Collection("Users").Document(user.email);
            await docRef.SetAsync(user);
            loginCheck log = new loginCheck("admin@example.com","password123");
            bool loginCorrect = await log.checkUser();
            Assert.IsTrue(loginCorrect);
            await docRef.DeleteAsync();
        }
        [TestMethod()]
        public async Task loginCheckTest_InCorrectCredentials_ReturnsFalse()
        {
            loginCheck log = new loginCheck("thisisnotacorrectemail","thisisnotacorrectpassword");
            bool loginIncorrect = await log.checkUser();
            Assert.IsFalse(loginIncorrect);
        }
        [TestMethod()]
        public async Task loginCheckTest_IsPasswordHashed_ReturnsTrue()
        {
            firebaseConfig config = firebaseConfig.Instance;
            FirestoreDb __database = config.getFirestoreDB();
            var user = new adminUser
            {
                email = "admin@example.com",
                fName = "John",
                lName = "Doe",
                password = "password123"
            };
            string passBeforeHash = user.password;
            user.password = BCrypt.Net.BCrypt.HashPassword(user.password);

            // Get the document reference and set the user data
            DocumentReference docRef = __database.Collection("Users").Document(user.email);
            await docRef.SetAsync(user);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            adminUser testUser = snapshot.ConvertTo<adminUser>();
            Assert.IsTrue(BCrypt.Net.BCrypt.Verify(passBeforeHash,testUser.password));
            await docRef.DeleteAsync();
        }


    }
}