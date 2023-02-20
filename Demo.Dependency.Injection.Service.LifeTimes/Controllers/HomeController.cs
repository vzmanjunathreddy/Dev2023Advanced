using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;
using Demo.Dependency.Injection.Service.LifeTimes.Models;
using Demo.Dependency.Injection.Service.LifeTimes.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace Demo.Dependency.Injection.Service.LifeTimes.Controllers
{
    public class HomeController : Controller
    {

        private ITransientService _transientService1;
        private ITransientService _transientService2;

        private IScopedService _scopedService1;
        private IScopedService _scopedService2;

        private ISignleTonService _signleTonService1;
        private ISignleTonService _signleTonService2;

        public HomeController(ITransientService traseintService1, ITransientService transientService2,
                              IScopedService scopedService1, IScopedService scopedService2,
                              ISignleTonService signleTonService1, ISignleTonService signleTonService2)
        {
            _transientService1 = traseintService1;
            _transientService2 = transientService2;

            _scopedService1 = scopedService1;
            _scopedService2 = scopedService2;

            _signleTonService1 = signleTonService1;
            _signleTonService2= signleTonService2;
        }

        public IActionResult Index()
        {
            var demoTransientservice1 = _transientService1.GetGuid();
            var demoTransientservice2 = _transientService2.GetGuid();

            var demoscopedservice1 = _scopedService1.GetGuid();
            var demoscopedservice2 = _scopedService2.GetGuid();

            var demosignleTonService1 = _signleTonService1.GetGuid();
            var demosignleTonService2 = _signleTonService2.GetGuid();

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