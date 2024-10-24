using Microsoft.VisualStudio.TestTools.UnitTesting;
using groomy.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using groomy.auth;
using groomy.services;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace groomy.Auth.Tests
{
    [TestClass()]
    public class createAdminUserTests
    {
        [TestMethod()]
        public async Task addAdminUserAsyncTest_AddingUserToDatabase_ShouldReturnSuccessful()
        {
            FirebaseConfig fConfig = FirebaseConfig.Instance;
            FirestoreDb data = fConfig.getFirestoreDB();
            createAdminUser admuser = new createAdminUser(data);
            var adminUser = new adminUser
            {
                email = "admin@example.com",
                fName = "John",
                lName = "Doe",
                password = "password123"
            };
            await admuser.addadminUserAsync(adminUser);
            DocumentReference potato = data.Collection("Users").Document(adminUser.email);
            DocumentSnapshot docSnap = await potato.GetSnapshotAsync();
            if (docSnap.Exists)
            {
                adminUser userFromDataBase = docSnap.ConvertTo<adminUser>();
                Assert.AreEqual(userFromDataBase.email, adminUser.email);
                Assert.AreEqual(userFromDataBase.fName, adminUser.fName);
                Assert.AreEqual(userFromDataBase.lName, adminUser.lName);
                Assert.AreEqual(userFromDataBase.password, adminUser.password);

            }
            else
            {
                Assert.Fail("docSnap doesn't exist");
            }
            await potato.DeleteAsync();
        }
    }
}