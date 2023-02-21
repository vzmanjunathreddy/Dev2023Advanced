using Demo.Dependency.Injection.Service.LifeTimes.Models;

namespace Demo.Dependency.Injection.Service.LifeTimes.Interfaces
{
    public interface IOrdersRepository
    {
        Task<IEnumerable<Orders>> GetListofOrders();
        Task<int>  GetCountofOrders();
    }
}
