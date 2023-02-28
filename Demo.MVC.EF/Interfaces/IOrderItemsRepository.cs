using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface IOrderItemsRepository : IGenericRepository<Orders>
    {
        Task<bool> Upsert(Orders entity);

    }
}
