using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Cloud.Firestore;
using groomy.Customers;
using groomy.Pricing;

namespace groomy.Invoices
{
    public class InvoiceCRUD : invoiceInterface
    {
        private FirestoreDb __db;
        private string __collectionName;

        public InvoiceCRUD(FirestoreDb db, string collectionName = "Invoices")
        {
            __db = db;
            __collectionName = collectionName;
        }

        public async Task CreateInvoice(Invoice invoice)
        {
            DocumentReference docRef = __db.Collection(__collectionName).Document();
            invoice.Id = docRef.Id;
            invoice.CreatedDate = DateTime.UtcNow;
            invoice.Deleted = false;

            // Calculate total based on line items
            invoice.Total = invoice.LineItems?.Sum(item => item.Cost * item.Quantity) ?? 0;

            await docRef.SetAsync(invoice);
        }

        public async Task<Invoice> GetInvoice(string documentId)
        {
            DocumentReference docRef = __db.Collection(__collectionName).Document(documentId);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                var invoice = snapshot.ConvertTo<Invoice>();
                return invoice.Deleted ? null : invoice;
            }

            return null;
        }

        public async Task<List<Invoice>> GetAllInvoices()
        {
            Query query = __db.Collection(__collectionName).OrderByDescending("createdDate");
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Documents
                .Select(doc => doc.ConvertTo<Invoice>())
                .Where(inv => !inv.Deleted)
                .ToList();
        }

        public async Task<List<Invoice>> GetUnpaidInvoices()
        {
            Query query = __db.Collection(__collectionName)
                .WhereEqualTo("isPaid", false)
                .WhereEqualTo("deleted", false)
                .OrderByDescending("createdDate");

            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Documents
                .Select(doc => doc.ConvertTo<Invoice>())
                .ToList();
        }
        public async Task<List<Invoice>> GetPaidInvoices()
        {
            Query query = __db.Collection(__collectionName)
                .WhereEqualTo("isPaid", true)
                .WhereEqualTo("deleted", false)
                .OrderByDescending("createdDate");

            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Documents
                .Select(doc => doc.ConvertTo<Invoice>())
                .ToList();
        }
        public async Task UpdateInvoice(Invoice invoice)
        {
            // Recalculate total
            invoice.Total = invoice.LineItems?.Sum(item => item.Cost * item.Quantity) ?? 0;

            DocumentReference docRef = __db.Collection(__collectionName).Document(invoice.Id);
            await docRef.SetAsync(invoice, SetOptions.MergeAll);
        }

        public async Task SoftDeleteInvoice(string documentId)
        {
            DocumentReference docRef = __db.Collection(__collectionName).Document(documentId);
            var snapshot = await docRef.GetSnapshotAsync();

            if (snapshot.Exists)
            {
                var invoice = snapshot.ConvertTo<Invoice>();
                invoice.Deleted = true;
                await docRef.SetAsync(invoice, SetOptions.MergeAll);
            }
        }
    }
}