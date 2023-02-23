using Demo.EFCore.GenericRepository.MVC.Models;
using System.Security.Cryptography;

namespace Demo.EFCore.GenericRepository.MVC.Interfaces
{
    public interface ICustomersRepository:IGenericRepository<Customers>
    {
        Task<bool> Upsert(Customers entity);

    }
}
