using Demo.EFCore.GenericRepository.MVC.Models;

namespace Demo.EFCore.GenericRepository.MVC.Interfaces
{
    public interface IOrdersRepository:IGenericRepository<Orders>
    {
        Task<bool> Upsert(Orders entity);

    }
}
