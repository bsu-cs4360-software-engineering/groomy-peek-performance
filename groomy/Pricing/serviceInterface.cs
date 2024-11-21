using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groomy.Pricing
{
    public interface serviceInterface
    {
        Task CreateService(Service addableService);

        Task<Service> GetService(string documentID);

        Task SoftDeleteService(string documentID);

        Task UpdateService(Service updatedService);

        Task<List<Service>> GetAllServices();
    }
}