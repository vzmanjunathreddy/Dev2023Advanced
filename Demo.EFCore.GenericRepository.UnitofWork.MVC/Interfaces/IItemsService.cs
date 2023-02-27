using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.UnitofWork.MVC.Interfaces
{
    public interface IItemsService
    {
        Task<IEnumerable<ItemsDTO>> GetAllItems();
    }
}
