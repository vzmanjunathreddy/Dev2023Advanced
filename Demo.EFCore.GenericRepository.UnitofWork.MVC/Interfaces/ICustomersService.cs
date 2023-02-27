using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.UnitofWork.MVC.Interfaces
{
    public interface ICustomersService
    {
        Task<IEnumerable<CustomersDTO>> GetCustomers();
        Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers);
        Task<bool> UpdateCustomers(CustomersDTO customers);
        Task<bool> DeleteCustomers(int customerId);
    }
}
