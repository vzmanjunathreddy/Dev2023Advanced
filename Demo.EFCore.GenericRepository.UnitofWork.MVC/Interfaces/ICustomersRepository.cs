using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;
using System.Security.Cryptography;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces
{
    public interface ICustomersRepository : IGenericRepository<Customers>
    {
        Task<bool> Upsert(Customers entity);

    }
}
