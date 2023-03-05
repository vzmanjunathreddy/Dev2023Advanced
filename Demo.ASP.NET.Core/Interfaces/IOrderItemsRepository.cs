using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IOrderItemsRepository : IGenericRepository<Orders>
    {
        Task<bool> Upsert(Orders entity);

    }
}
