using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Interfaces
{
    public interface IFoodOrdersService : ICustomersService, IOrdersService, IItemsService
    {

        Task<bool> AddfoodOrder(CustomersDTO customers);

    }
}
