using Demo.EFCore.MVC.Interfaces;
using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        private readonly ADVFoodDbContext _dbContext;

        public OrdersRepository(ADVFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddOrders(Orders orders)
        {
            bool isAdded = false;
            try
            {
                await _dbContext.Orders.AddAsync(orders);
                await _dbContext.SaveChangesAsync();
                isAdded = true;
            }
            catch (Exception ex)
            {

            }
            return isAdded;
        }

        public async Task<bool> AddRangeofOrders(IEnumerable<Orders> orders)
        {
            bool isAdded = false;
            try
            {
                await _dbContext.Orders.AddRangeAsync(orders);
                await _dbContext.SaveChangesAsync();
                isAdded = true;
            }

            catch (Exception ex)
            {

            }
            return isAdded;
        }

        public Task<bool> DeleteOrders(Orders orders)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Orders>> GetOrders()
        {
            IQueryable<Orders> result = null;

            try
            {
                result = _dbContext.Orders.AsQueryable();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public Task<bool> UpdateOrders(Orders orders)
        {
            throw new NotImplementedException();
        }
    }
}
