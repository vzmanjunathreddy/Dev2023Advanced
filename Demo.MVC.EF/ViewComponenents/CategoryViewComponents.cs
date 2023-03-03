using Demo.MVC.EF.Data;
using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.EF.ViewComponenents
{
    [ViewComponent(Name = "Category")]
    public class CategoryViewComponents : ViewComponent
    {
        private ADVFoodDbContext _dbcontext;
        public CategoryViewComponents(ADVFoodDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories1 = _dbcontext.Items.Select(x => x.Category).Distinct().ToList();

            var categories2 = _dbcontext.Items;

            var categories3 = _dbcontext.Items.Distinct().Select(x => new CategoryViewModel
            {
                Category = x.Category
            });

            var categoriesmock =new List<string> { "Breakfast", "Lunch", "Dinner" };

            return View("Index", categories1);
        }
    }
}
