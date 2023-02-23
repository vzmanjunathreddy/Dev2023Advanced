using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Interfaces
{
    public interface IOrdersRepository
    {
        Task<IQueryable<Orders>> GetOrders();
        Task<bool> AddOrders(Orders orders);
        Task<bool> AddRangeofOrders(IEnumerable<Orders> orders);
        Task<bool> UpdateOrders(Orders orders);
        Task<bool> DeleteOrders(Orders orders);
    }
}
