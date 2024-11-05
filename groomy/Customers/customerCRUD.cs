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

        public async Task<Dictionary<string, customer>> getAllCustomers()
        {
            var customers = new Dictionary<string, customer>();
            Query query = __db.Collection("customers");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    var customerData = document.ConvertTo<customer>();
                    customers.Add(document.Id, customerData);
                }
            }

            return customers;
        }

        public async Task addCustomerAsync(customer customer)
        {
            DocumentReference docRef = __db.Collection("customers").Document();
            await docRef.SetAsync(customer);
            Console.WriteLine($"Added customer with ID: {docRef.Id}");
        }

        public async Task<customer> getCustomerById(string customerId)
        {
            DocumentReference docRef = __db.Collection("customers").Document(customerId);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                return snapshot.ConvertTo<customer>();
            }

            return null; 
        }

        public async Task<customer> getCustomerByEmail(string customerEmail)
        {
            Query query = __db.Collection("customers").WhereEqualTo("email", customerEmail);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                return snapshot.Documents.First().ConvertTo<customer>();
            }

            return null;
        }

        public async Task updateCustomer(customer customer)
        {
            DocumentReference docRef = __db.Collection("customers").Document(customer.id.ToString());
            await docRef.SetAsync(customer, SetOptions.MergeAll);
            Console.WriteLine($"Updated customer with ID: {customer.id}");
        }

        public async Task deleteCustomerById(string customerId)
        {
            DocumentReference docRef = __db.Collection("customers").Document(customerId);
            var newData = new
            {
                deleted = true
            };
            await docRef.SetAsync(newData);
            Console.WriteLine($"Marked customer with ID: {customerId} as deleted.");

        }
    }
}