using System;
using System.IO;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace groomy.services
{
    public class firebaseConfig
    {
        private readonly string credentialsPath = AppDomain.CurrentDomain.BaseDirectory + @"/Services/firebaseSDK.json";
        private FirestoreDb firestoreDb;
        private static firebaseConfig __instance;

        // Private constructor to prevent instantiation
        private firebaseConfig()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", credentialsPath);

            Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}");
            Console.WriteLine($"Checking for file at path: {credentialsPath}");
            Console.WriteLine($"File exists: {File.Exists(credentialsPath)}");

            if (!File.Exists(credentialsPath))
            {
                throw new ArgumentException("Invalid Firebase credentials path.");
            }

            initializeFirebase();
            firestoreDb = FirestoreDb.Create("groomy-52011");
        }

        // Public static method to access the instance
        public static firebaseConfig Instance
        {
            get
            {
                if (__instance == null)
                {
                    __instance = new firebaseConfig();
                }
                return __instance;
            }
        }

        public FirestoreDb getFirestoreDB()
        {
            return firestoreDb;
        }

        private void initializeFirebase()
        {
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