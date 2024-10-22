using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groomy.Services;
using Google.Cloud.Firestore;

namespace groomy.Auth
{
    internal class loginCheck
    {
        private FirestoreDb __database;
        private readonly string __email;
        private readonly string __password;
        private FirebaseConfig __firebaseConfig;
        public loginCheck(string email, string password) 
        {
            __email = email;
            __password = password;
            __database = __firebaseConfig.getFirestoreDB();
        }
        private async Task<bool> checkEmail()
        {

            try
            {
                DocumentReference docRef = __database.Collection("Users").Document(__email);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                return snapshot.Exists; // Returns true if the document exists
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking email: {ex.Message}");
                return false;
            }
        }
        private async Task<bool> checkPass()
        {

            try
            {
                DocumentReference docRef = __database.Collection("Users").Document(__email);
                DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    AdminUser user = snapshot.ConvertTo<AdminUser>();
                    return __password == user.password;
                }
                return false;
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error checking email: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> checkUser()
        {                                   
            bool emailExists = await checkEmail();
            bool passExists = await checkPass();
            return emailExists && passExists;
        }
    }
}
