using Demo.EFCore.MVC.Data;
using Demo.EFCore.MVC.Interfaces;
using Demo.EFCore.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Demo.EFCore.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFoodOrdersService _foodOrdersService;

        public HomeController(ILogger<HomeController> logger, ADVFoodDbContext dbContext, IFoodOrdersService customerService)
        {
            _logger = logger;
            _foodOrdersService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var result =await _foodOrdersService.GetCustomers();

            var orders= await _foodOrdersService.GetOrders();

            return View();
        }

        public IActionResult Students()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}