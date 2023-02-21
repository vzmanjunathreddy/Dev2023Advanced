using Demo.Dependency.Injection.Service.LifeTimes.Models;

namespace Demo.Dependency.Injection.Service.LifeTimes.Interfaces
{
    public interface IOrderService
    {
        Task<IEnumerable<OrdersDTO>> GetOrdersList();

        int GetOrdersCount();
    }
}
