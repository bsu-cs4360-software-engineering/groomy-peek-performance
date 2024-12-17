using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;

namespace groomy.Invoices
{
    [FirestoreData]
    public class Invoice
    {
        [FirestoreProperty("id")]
        public string Id { get; set; }

        [FirestoreProperty("clientId")]
        public string ClientId { get; set; }

        [FirestoreProperty("createdDate")]
        public Timestamp CreatedDate { get; set; }

        [FirestoreProperty("dueDate")]
        public Timestamp DueDate { get; set; }

        [FirestoreProperty("isPaid")]
        public bool IsPaid { get; set; }

        [FirestoreProperty("total")]
        public double Total { get; set; }

        [FirestoreProperty("lineItems")]
        public List<LineItem> LineItems { get; set; }

        [FirestoreProperty("deleted")]
        public bool Deleted { get; set; }
    }

    [FirestoreData]
    public class LineItem
    {
        [FirestoreProperty("serviceId")]
        public string ServiceId { get; set; }

        [FirestoreProperty("serviceName")]
        public string ServiceName { get; set; }

        [FirestoreProperty("cost")]
        public double Cost { get; set; }

        [FirestoreProperty("quantity")]
        public int Quantity { get; set; }
    }
}