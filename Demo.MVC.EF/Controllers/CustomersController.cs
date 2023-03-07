using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using X.PagedList;

namespace Demo.MVC.EF.Controllers
{
    public class CustomersController : Controller
    {
        // GET: CustomersController

        private readonly IFoodOrdersService _foodOrdersService;

        public CustomersController(IFoodOrdersService foodOrdersService)
        {
            _foodOrdersService = foodOrdersService;
        }
        public async Task<ActionResult> Index(int? page)  // Action Methods
        {
            var customers = await _foodOrdersService.GetCustomers(); // 2 sec



            var pageNumber = page ?? 1; 
            var onePageOfProducts = customers.ToPagedList(pageNumber, 2); // will only contain 25 products max because of the pageSize

            ViewBag.OnePageOfProducts = onePageOfProducts;

            //if(searchString != null) {

            //var orders = await _foodOrdersService.GetOrders(); // 3 sec

            //var items = await _foodOrdersService.GetAllItemsItems(); // 1sec


            //     var resultofCustomers = customers.Where(x => x.Email.Contains(searchString) || x.Name.Contains(searchString) || x.City.Contains(searchString)).ToList();

            //     var resultofOrders = orders.Where(x => x.Quantity.ToString().Contains(searchString)).ToList();

            //     var resultofItems = items.Where(x => x.Name.Contains(searchString) || x.Category.Contains(searchString)).ToList();

            //     SearchViewModel searchViewModel = new SearchViewModel()
            //     {
            //         Customers = resultofCustomers,
            //         Items = items,
            //         Orders = orders
            //     }; var result= _dbcontext.FromSQLRaw("sp", Param)





            return View(onePageOfProducts);
        }

        // GET: CustomersController/Details/5
        public async Task<ActionResult> Details(string email)
        {
            var customersData = await _foodOrdersService.GetCustomers();

            var cusutomer= customersData.Where(x=>x.Email.ToLower()==email.ToLower()).FirstOrDefault();


            return View(cusutomer);
        }

        // GET: CustomersController/Create

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customers customer)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
