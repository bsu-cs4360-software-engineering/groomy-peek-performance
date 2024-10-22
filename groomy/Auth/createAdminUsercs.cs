using System;
using System.Threading.Tasks;
using groomy.Services; // Ensure this matches your FirebaseConfig namespace
using Google.Cloud.Firestore;

namespace groomy.Auth
{
    internal class createAdminUser
    {
        private readonly FirestoreDb _firestoreDb;

        public createAdminUser()
        {
            // Initialize Firestore database through FirebaseConfig
            var firebaseConfig = new FirebaseConfig();
            _firestoreDb = firebaseConfig.getFirestoreDB();
        }

        // Method to create a new admin user
        public async Task AddAdminUserAsync(AdminUser user)
        {
            try
            {
                DocumentReference docRef = _firestoreDb.Collection("Users").Document(user.email);
                await docRef.SetAsync(user);
                Console.WriteLine($"Admin user {user.fName} {user.lName} added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding admin user: {ex.Message}");
            }
        }
    }
}
