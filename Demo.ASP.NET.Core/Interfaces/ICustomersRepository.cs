using Demo.ASP.NET.Core.Models;
using System.Security.Cryptography;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface ICustomersRepository : IGenericRepository<Customers>
    {
        Task<bool> Upsert(Customers entity);

    }
}
