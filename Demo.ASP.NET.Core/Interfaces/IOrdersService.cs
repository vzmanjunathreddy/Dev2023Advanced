using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IOrdersService
    {
        Task<IEnumerable<OrdersDTO>> GetOrders();
    }
}
