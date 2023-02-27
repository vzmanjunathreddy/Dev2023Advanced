using Demo.MVC.EF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.MVC.EF.Controllers
{
    public class DemoController : Controller
    {

        //IActionResult is Action Result (combil
        public IActionResult Index(int id, string name) // Action Method
        {
            var welcomeMessage= $"Welcome to Advanced MVC {name} and {id}";

            ViewBag.Welcome = welcomeMessage;

            return View();

        }

        public IActionResult CustomerData() // Action Method
        {
            Customer customer = new Customer()
            {
                Id = 12,
                Name = "Yuvraj",
                Email = "yuvi@abc.com"
            };

            ViewBag.Customer = customer;

            return View();

        }

        public IActionResult EmployeeData()
        {
            Customer customer = new Customer()
            {
                Id = 101,
                Name = "Sachin",
                Email = "Sachin@abc.com"
            };


            return View(customer);

        }
    }
}
