using Demo.ASP.NET.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.ASP.NET.Core.Data
{

    public class UnitofWork : IUnitofWork
    {
        private ADVFoodDbContext _dbContext;

        public ICustomersRepository CustomersRepository { get; set; }
        public IItemsRepository ItemsRepository { get; set; }
        public IOrdersRepository OrdersRepository { get; set; }

        public UnitofWork(ADVFoodDbContext dbContext)
        {
            _dbContext = dbContext;
            CustomersRepository = new CustomersRepository(dbContext);
            OrdersRepository = new OrdersRepository(dbContext);
            ItemsRepository = new ItemsRepository(dbContext);
        }

        public void SaveChangestoDB()
        {
            _dbContext.SaveChanges();

        }
    }
}
