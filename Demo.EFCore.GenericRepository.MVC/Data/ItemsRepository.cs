using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.MVC.Models;

namespace Demo.EFCore.GenericRepository.MVC.Data
{
    public class ItemsRepository:GenericRepository<Items>, IItemsRepository
    {
        public ItemsRepository(ADVFoodDbContext dbContext):base(dbContext)
        {

        }
    }
}
