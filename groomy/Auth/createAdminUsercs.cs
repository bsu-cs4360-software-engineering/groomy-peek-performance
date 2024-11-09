using System;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using groomy.Auth;

namespace groomy.auth
{
    public class createAdminUser
    {
        private readonly FirestoreDb __firestoreDb;

        // Constructor to inject FirestoreDb (useful for testing)
        public createAdminUser(FirestoreDb firestoreDb)
        {
            this.__firestoreDb = firestoreDb;
        }

        // Method to create a new admin user
        public async Task addadminUserAsync(adminUser user)
        {
            try
            {
                // Hash the password
                user.password = BCrypt.Net.BCrypt.HashPassword(user.password);

                // Get the document reference and set the user data
                DocumentReference docRef = __firestoreDb.Collection("Users").Document(user.email);
                await docRef.SetAsync(user);

                //Console.WriteLine($"Admin user {user.fName} {user.password} added successfully.");
            }
            catch (Exception ex)
            {
                //Console.WriteLine($"Error adding admin user: {ex.Message}");
                throw;  // Rethrow the exception to ensure it can be caught in tests
            }
        }
    }
}
