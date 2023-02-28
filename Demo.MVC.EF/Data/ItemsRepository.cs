using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Models;

namespace Demo.MVC.EF.Data
{
    public class ItemsRepository : GenericRepository<Items>, IItemsRepository
    {
        public ItemsRepository(ADVFoodDbContext dbContext) : base(dbContext)
        {

        }
    }
}
