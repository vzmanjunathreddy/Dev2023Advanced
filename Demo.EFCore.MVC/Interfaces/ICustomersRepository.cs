using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Interfaces
{
    public interface ICustomersRepository
    {
        Task<IQueryable<Customers>> GetCustomers();
        Task<bool> AddCustomer(Customers customers);
        Task<bool> AddRangeofCustomers(IEnumerable<Customers> customers);
        Task<bool> UpdateCustomers(Customers customers);
        Task<bool> DeleteCustomers(Customers customers);

    }
}
