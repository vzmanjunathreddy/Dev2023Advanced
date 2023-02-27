using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;
using Demo.EFCore.GenericRepository.UnitofWork.MVC.Interfaces;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces
{
    public interface IFoodOrdersService : ICustomersService, IOrdersService, IItemsService
    {

        Task<bool> AddfoodOrder(CustomersDTO customers);

    }
}
