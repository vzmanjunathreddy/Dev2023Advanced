using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IOrdersRepository : IGenericRepository<Orders>
    {
        Task<bool> Upsert(Customers entity);
    }
}
