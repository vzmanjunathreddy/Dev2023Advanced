using Demo.MVC.EF.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> Index()
        {
            var customers = await _foodOrdersService.GetCustomers();

            return View(customers);
        }

        // GET: CustomersController/Details/5
        public async Task<ActionResult> Details(string email)
        {
            var customersData = await _foodOrdersService.GetCustomers();

            var cusutomer= customersData.Where(x=>x.Email.ToLower()==email.ToLower()).FirstOrDefault();


            return View(cusutomer);
        }

        // GET: CustomersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
