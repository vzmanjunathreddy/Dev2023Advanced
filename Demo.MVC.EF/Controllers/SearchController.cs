using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.EF.Controllers
{
    public class SearchController : Controller
    {

        private readonly IFoodOrdersService _foodOrdersService;

        public SearchController(IFoodOrdersService foodOrdersService)
        {
            _foodOrdersService = foodOrdersService;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            SearchViewModel searchViewModel = null;


            if (searchString != null)
            {
                var customers = _foodOrdersService.GetCustomers(); //3sec

                var orders = _foodOrdersService.GetOrders(); // 3 sec

                var items = _foodOrdersService.GetAllItemsItems(); // 1sec

                await Task.WhenAll(customers, orders, items); // Async call to the database


                var resultofCustomers = customers.Result.Where(x => x.Email.ToLower().Contains(searchString.ToLower()) ||
                                                                     x.Name.ToLower().Contains(searchString.ToLower()) ||
                                                                     x.City.ToLower().Contains(searchString.ToLower())).ToList();

                var resultofOrders = orders.Result.Where(x => x.Quantity.ToString().Contains(searchString)).ToList();

                var resultofItems = items.Result.Where(x => x.Name.ToLower().Contains(searchString.ToLower()) ||
                                                            x.Category.ToLower().Contains(searchString.ToLower())).ToList();

                searchViewModel = new SearchViewModel()
                {
                    Customers = resultofCustomers,
                    Items = resultofItems,
                    Orders = resultofOrders
                };
            }
            return View(searchViewModel);
        }
    }
}

