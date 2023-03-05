using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IItemsService
    {
        Task<IEnumerable<ItemsDTO>> GetAllItemsItems();

        ItemsDTO GetItemById(int id);
    }
}
