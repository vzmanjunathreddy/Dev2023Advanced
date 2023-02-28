using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface IOrdersService
    {
        Task<IEnumerable<OrdersDTO>> GetOrders();
    }
}
