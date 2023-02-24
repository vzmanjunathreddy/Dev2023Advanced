using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Data
{
    public class ItemsRepository : GenericRepository<Items>, IItemsRepository
    {
        public ItemsRepository(ADVFoodDbContext dbContext) : base(dbContext)
        {

        }
    }
}
