using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface ICustomersService
    {
        Task<IEnumerable<CustomersDTO>> GetCustomers();
        Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers);
        Task<bool> UpdateCustomers(CustomersDTO customers);
        Task<bool> DeleteCustomers(int customerId);
    }
}
