using Demo.Core.ItemsAPI.Models;

namespace Demo.Core.ItemsAPI.Interfaces
{
    public interface IItemsService
    {
        Task<Orders> GetOrderItems();
    }
}
