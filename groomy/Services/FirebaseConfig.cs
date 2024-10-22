using System;
using System.IO;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;

namespace groomy.Services
{
    internal class FirebaseConfig
    {
        private readonly string __credentialsPath = AppDomain.CurrentDomain.BaseDirectory + @"/Services/firebaseSDK.json";
        private FirestoreDb __firestoreDB;
        public FirebaseConfig()
        {
            // Testing output
            Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Checking for file at path: {__credentialsPath}");
            Console.WriteLine($"File exists: {File.Exists(__credentialsPath)}");

            if (string.IsNullOrWhiteSpace(__credentialsPath) || !File.Exists(__credentialsPath))
            {
                throw new ArgumentException("Invalid Firebase credentials path.");
            }
            InitializeFirebase();
            __firestoreDB = FirestoreDb.Create("groomy-52011");

        }
        public FirestoreDb getFirestoreDB()
        {
            return __firestoreDB;
        }
        private void InitializeFirebase()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", __credentialsPath);
            if (FirebaseApp.DefaultInstance == null)
            {
                FirebaseApp.Create(new AppOptions
                {
                    Credential = GoogleCredential.GetApplicationDefault()
                });
            }

            Console.WriteLine("Firebase initialized successfully.");
        }
    }
}