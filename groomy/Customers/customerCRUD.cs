using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using groomy.services;
using Google.Cloud.Firestore;

namespace groomy.Customers
{
    public class customerCRUD : customerInterface
    {
        private FirestoreDb __db;

        public customerCRUD(FirestoreDb db)
        {
            __db = db;
        }

        public async Task<List<customer>> getAllCustomers()
        {
            var customers = new List<customer>();
            Query query = __db.Collection("Customers");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            Console.WriteLine($"Total documents: {snapshot.Documents.Count}"); // Print count only once

            foreach (DocumentSnapshot document in snapshot.Documents)
            {

                if (document.Exists)
                {
                    var customerData = document.ConvertTo<customer>();
                    customers.Add(customerData);
                }
            }
            return customers;
        }

        public async Task addCustomerAsync(customer customer)

        {
            DocumentReference docRef = __db.Collection("Customers").Document();
            customer.id = docRef.Id;
            await docRef.SetAsync(customer);
            Console.WriteLine($"Added customer with ID: {customer.id}");
        }

        public async Task<customer> getCustomerById(string customerId)
        {
            DocumentReference docRef = __db.Collection("Customers").Document(customerId);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<customer>();
            }

            return null;
        }

        public async Task<customer> getCustomerByEmail(string customerEmail)
        {
            Query query = __db.Collection("Customers").WhereEqualTo("email", customerEmail);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                return snapshot.Documents.First().ConvertTo<customer>();
            }

            return null;
        }

        public async Task<string> getDocumentId(string customerEmail)
        {
            Query query = __db.Collection("Customers").WhereEqualTo("email", customerEmail);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                // Return the document ID of the first matching document
                return snapshot.Documents.First().Id;
            }

            return null; // Return null if no customer is found
        }

        public async Task updateCustomer(customer customer)
        {
            DocumentReference docRef = __db.Collection("Customers").Document(customer.id.ToString());
            await docRef.SetAsync(customer, SetOptions.MergeAll);
            Console.WriteLine($"Updated customer with ID: {customer.id}");
        }

        public async Task deleteCustomerByEmail(string email)
        {
            // Query to find the customer document by email
            var query = __db.Collection("Customers").WhereEqualTo("email", email);
            var querySnapshot = await query.GetSnapshotAsync();

            if (querySnapshot.Count > 0)
            {
                // Assuming email is unique, we take the first document
                DocumentSnapshot docSnapshot = querySnapshot.Documents[0];
                DocumentReference docRef = docSnapshot.Reference;

                var newData = new
                {
                    deleted = true
                };

                // Mark the customer as deleted
                await docRef.SetAsync(newData, SetOptions.MergeAll);
                Console.WriteLine($"Marked customer with email: {email} as deleted.");
            }
            else
            {
                Console.WriteLine($"No customer found with email: {email}.");
            }
        }
    }
}