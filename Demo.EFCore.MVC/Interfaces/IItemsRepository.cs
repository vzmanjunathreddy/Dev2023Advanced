using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Interfaces
{
    public interface IItemsRepository
    {
        Task<IQueryable<Items>> GetallItems();
        Task<bool> AddItems(Items orders);
        Task<bool> AddRangeofItems(IEnumerable<Items> orders);
        Task<bool> UpdateItems(Items orders);
        Task<bool> DeleteItems(Items orders);
    }
}
