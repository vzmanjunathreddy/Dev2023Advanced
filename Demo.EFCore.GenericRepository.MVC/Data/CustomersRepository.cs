
using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.EFCore.GenericRepository.MVC.Data
{
    public class CustomersRepository : GenericRepository<Customers>, ICustomersRepository
    {
        public CustomersRepository(ADVFoodDbContext dbContext) : base(dbContext)
        {

        }


        // Upsert method is used if record exists it will update else it will add new record
        public async Task<bool> Upsert(Customers entity)
        {
            try
            {
                // _dbset is from GenericRepository 

                var customer = _dbSet.Where(x => x.Id == entity.Id).FirstOrDefault();
                if (customer == null)
                {
                    _dbSet.Add(entity);
                    return true;
                }

                customer.Name = customer.Name;
                customer.City = customer.City;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
