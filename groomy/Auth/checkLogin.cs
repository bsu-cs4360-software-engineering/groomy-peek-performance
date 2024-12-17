using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groomy.services;
using Google.Cloud.Firestore;

namespace groomy.Auth
{
    public class loginCheck
    {
        private FirestoreDb __database;
        private readonly string __email;
        private readonly string __password;
        private firebaseConfig __firebaseConfig = firebaseConfig.Instance;
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
                //Console.WriteLine($"Error checking email: {ex.Message}");
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
                    adminUser user = snapshot.ConvertTo<adminUser>();
                    bool isPasswordValid = BCrypt.Net.BCrypt.Verify(__password, user.password);
                    return isPasswordValid;
                }
                return false;

            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error checking email: {ex.Message}");
                return false;
            }
        }
        public async Task<bool> checkUser()
        {
            bool emailExists = await checkEmail();
            bool passExists = await checkPass();
            return emailExists && passExists;
        }

        public async Task<bool> IsValidEmail(string email)
        {
            bool Result = false;
            try
            {
                var emailValidator = new System.Net.Mail.MailAddress(email);
                Result = (email.LastIndexOf(".") > email.LastIndexOf("@"));
            }
            catch
            {
                Result = false;
            }
            return Result;
        }
    }
}
