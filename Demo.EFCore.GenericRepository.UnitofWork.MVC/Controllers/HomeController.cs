using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Formats.Asn1;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IFoodOrdersService _foodOrdersService;

        public HomeController(ILogger<HomeController> logger, IFoodOrdersService customerService)
        {
            _logger = logger;
            _foodOrdersService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _foodOrdersService.GetCustomers();

            var orders = await _foodOrdersService.GetOrders();

            var items = await _foodOrdersService.GetAllItems();

            return View();
        }

        public async Task<IActionResult> CreateFoodOrder()
        {
            var result = await _foodOrdersService.AddfoodOrder(null);
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }

}