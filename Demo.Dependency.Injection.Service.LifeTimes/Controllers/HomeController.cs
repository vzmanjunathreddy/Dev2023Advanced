using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;
using Demo.Dependency.Injection.Service.LifeTimes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Demo.Dependency.Injection.Service.LifeTimes.Controllers
{
    public class HomeController : Controller
    {

        private ITransientService _traseitntService;
        private IScopedService _scopedService;
        private ISignleTonService _signleTonService;
        public HomeController(ITransientService traseintService, IScopedService scopedService, ISignleTonService signleTonService)
        {
            _traseitntService = traseintService;
            _scopedService = scopedService;
            _signleTonService = signleTonService;
        }

        public IActionResult Index()
        {
            var demoTransientservice1 = _traseitntService.GetGuid();
            var demoTransientservice2 = _traseitntService.GetGuid();

            var demoscopedservice1 = _scopedService.GetGuid();
            var demoscopedservice2 = _scopedService.GetGuid();

            var demosignleTonService1 = _signleTonService.GetGuid();
            var demosignleTonService2 = _signleTonService.GetGuid();

            StringBuilder serviceLifeTimeStringbuilder= new StringBuilder();

            serviceLifeTimeStringbuilder.Append($"Transient Service 1 : {demoTransientservice1}\n");
            serviceLifeTimeStringbuilder.Append($"Transient Service 2 : {demoTransientservice2}\n\n\n");


            serviceLifeTimeStringbuilder.Append($"ScopedService Service 1 : {demoscopedservice1}\n");
            serviceLifeTimeStringbuilder.Append($"ScopedService Service 2 : {demoscopedservice2}\n\n\n");

            serviceLifeTimeStringbuilder.Append($"SignleTonService Service 1 : {demosignleTonService1}\n");
            serviceLifeTimeStringbuilder.Append($"SignleTonService Service 2 : {demosignleTonService2}");

            return Ok(serviceLifeTimeStringbuilder.ToString());


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