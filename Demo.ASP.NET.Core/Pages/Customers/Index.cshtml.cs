using Demo.ASP.NET.Core.Interfaces;
using Demo.ASP.NET.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.ASP.NET.Core.Pages.Customers
{
    public class IndexModel : PageModel
    {

        private readonly IFoodOrdersService _foodOrdersService;

        [BindProperty]
        public IEnumerable<ItemsDTO> Items { get; set; }

        public IndexModel(IFoodOrdersService foodOrdersService)
        {
            _foodOrdersService = foodOrdersService;
        }
        public async void OnGet()
        {
          Items=  await _foodOrdersService.GetAllItemsItems();
        }
    }
}
