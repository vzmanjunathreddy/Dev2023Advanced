using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.MVC.Interfaces
{
    public interface IOrdersRepository:IGenericRepository<Orders>
    {
        Task<bool> Upsert(Customers entity);
    }
}
