using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace groomy.Customers
{
    public interface customerInterface
    {
        Task addCustomerAsync(customer customer);
        Task<customer> getCustomerById(string customerId);
        Task<customer> getCustomerByEmail(string customerEmail);
        Task<Dictionary<string, customer>> getAllCustomers();
        Task updateCustomer(customer customer);
        Task deleteCustomerByEmail(string customerId);
    }
}
