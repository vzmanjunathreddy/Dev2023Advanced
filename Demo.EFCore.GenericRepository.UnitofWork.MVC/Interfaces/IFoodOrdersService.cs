using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces
{
    public interface IFoodOrdersService
    {
        Task<IEnumerable<CustomersDTO>> GetCustomers();
        Task<bool> AddfoodOrder(CustomersDTO customers);
        Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers);
        Task<bool> UpdateCustomers(CustomersDTO customers);
        Task<bool> DeleteCustomers(int customerId);

        Task<IEnumerable<OrdersDTO>> GetOrders();

    }
}
