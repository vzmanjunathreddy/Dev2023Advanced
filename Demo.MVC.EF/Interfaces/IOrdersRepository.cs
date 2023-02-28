using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface IOrdersRepository : IGenericRepository<Orders>
    {
        Task<bool> Upsert(Customers entity);
    }
}
