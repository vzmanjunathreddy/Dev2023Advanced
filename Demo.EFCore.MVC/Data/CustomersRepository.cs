using Demo.EFCore.MVC.Interfaces;
using Demo.EFCore.MVC.Models;

namespace Demo.EFCore.MVC.Data
{
    public class CustomersRepository : ICustomersRepository
    {
        private readonly ADVFoodDbContext _dbContext;
        public CustomersRepository(ADVFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddCustomer(Customers customers)
        {
            bool isAdded = false;
            try
            {
                await _dbContext.Customers.AddAsync(customers);
                await _dbContext.SaveChangesAsync();
                isAdded = true;
            }
            catch (Exception ex)
            {

            }
            return isAdded;
        }

        public async Task<bool> AddRangeofCustomers(IEnumerable<Customers> customers)
        {
            bool isAdded = false;
            try
            {
                await _dbContext.Customers.AddRangeAsync(customers);
                await _dbContext.SaveChangesAsync();
                isAdded = true;
            }

            catch (Exception ex)
            {

            }
            return isAdded;
        }

        public Task<bool> DeleteCustomers(Customers customers)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<Customers>> GetCustomers()
        {
            IQueryable<Customers> result = null;
            try
            {
                result = _dbContext.Customers.AsQueryable();
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public Task<bool> UpdateCustomers(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}
