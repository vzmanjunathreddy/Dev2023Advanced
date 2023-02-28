using Demo.MVC.EF.Models;
using System.Security.Cryptography;

namespace Demo.MVC.EF.Interfaces
{
    public interface ICustomersRepository : IGenericRepository<Customers>
    {
        Task<bool> Upsert(Customers entity);

    }
}
