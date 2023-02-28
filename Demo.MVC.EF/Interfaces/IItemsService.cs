using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface IItemsService
    {
        Task<IEnumerable<ItemsDTO>> GetAllItemsItems();

        ItemsDTO GetItemById(int id);
    }
}
