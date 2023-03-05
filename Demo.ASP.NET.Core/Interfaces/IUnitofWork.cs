using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.ASP.NET.Core.Interfaces
{
    public interface IUnitofWork
    {
        ICustomersRepository CustomersRepository { get; set; }

        IItemsRepository ItemsRepository { get; set; }

        IOrdersRepository OrdersRepository { get; set; }

        void SaveChangestoDB();
    }
}
