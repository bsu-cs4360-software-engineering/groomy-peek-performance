using System.Collections.Generic;
using System.Threading.Tasks;

namespace groomy.Invoices
{
    public interface invoiceInterface
    {
        Task CreateInvoice(Invoice invoice);
        Task<Invoice> GetInvoice(string documentId);
        Task<List<Invoice>> GetAllInvoices();
        Task<List<Invoice>> GetUnPaidInvoices();
        Task<List<Invoice>> GetPaidInvoices();
        Task UpdateInvoice(Invoice invoice);
        Task SoftDeleteInvoice(string documentId);
    }
}