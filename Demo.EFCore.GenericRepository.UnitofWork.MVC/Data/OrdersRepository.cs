using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Data
{
    public class OrdersRepository : GenericRepository<Orders>, IOrdersRepository
    {
        public OrdersRepository(ADVFoodDbContext dbcontext) : base(dbcontext)
        {

        }

        // Upsert method is used if record exists it will update else it will add new record
        public async Task<bool> Upsert(Orders entity)
        {
            try
            {
                // _dbset is from GenericRepository 

                var order = _dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
                if (order == null)
                {
                    _dbSet.Add(entity);
                    return true;
                }

                order.Quantity = order.Quantity;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Task<bool> Upsert(Customers entity)
        {
            throw new NotImplementedException();
        }
    }
}
