using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.UnitofWork.MVC.Interfaces
{
    public interface IOrdersService
    {
        Task<IEnumerable<OrdersDTO>> GetOrders();
    }
}
