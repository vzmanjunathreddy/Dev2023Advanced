using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IFoodOrdersService : ICustomersService, IOrdersService, IItemsService
    {

        Task<bool> AddfoodOrder(CustomersDTO customers);

    }
}
