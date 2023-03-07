using Demo.MVC.EF.Data;
using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.EF.ViewComponenents
{
    [ViewComponent(Name = "CheckboxCategory")]
    public class CheckboxCategoryViewComponents : ViewComponent
    {
        private ADVFoodDbContext _dbcontext;
        public CheckboxCategoryViewComponents(ADVFoodDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = _dbcontext.Items.Select(x => x.Category).Distinct().ToList();

            CustomerViewModel customerViewModel = new CustomerViewModel();

            List<CheckboxOptions>  options = new List<CheckboxOptions>();

            foreach (var category in categories)
            {
                options.Add(new CheckboxOptions()
                {
                    Value = category,
                    Description = category,
                    isChecked = category=="Beverages"?false: true
                });
            }

            customerViewModel.Checkboxes = options;

            return View("Index", customerViewModel);
        }
    }
}
