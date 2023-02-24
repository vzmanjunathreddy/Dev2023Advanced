using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.MVC.Interfaces
{
    public interface IOrderItemsRepository: IGenericRepository<Orders>
    {
        Task<bool> Upsert(Orders entity);

    }
}
