using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Interfaces
{
    public interface IFoodOrdersService
    {
        Task<IEnumerable<CustomersDTO>> GetCustomers();
        Task<bool> AddCustomer(CustomersDTO customers);
        Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers);
        Task<bool> UpdateCustomers(CustomersDTO customers);
        Task<bool> DeleteCustomers(int customerId);

        Task<IEnumerable<OrdersDTO>> GetOrders();

    }
}
