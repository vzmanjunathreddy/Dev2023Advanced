using Demo.ASP.NET.Core.Interfaces;
using Demo.ASP.NET.Core.Models;

namespace Demo.ASP.NET.Core.Data
{
    public class ItemsRepository : GenericRepository<Items>, IItemsRepository
    {
        public ItemsRepository(ADVFoodDbContext dbContext) : base(dbContext)
        {

        }
    }
}
