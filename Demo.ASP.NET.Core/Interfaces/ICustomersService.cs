using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface ICustomersService
    {
        Task<IEnumerable<CustomersDTO>> GetCustomers();
        Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers);
        Task<bool> UpdateCustomers(CustomersDTO customers);
        Task<bool> DeleteCustomers(int customerId);
    }
}
