using Demo.ASP.NET.Core.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Demo.ASP.NET.Core.Pages.Customers
{
    public class CustomersModel : PageModel
    {
        ADVFoodDbContext dbContex;
        public CustomersModel(ADVFoodDbContext dbContex)
        {
            this.dbContex = dbContex;
        }
        [BindProperty]
        public string WelcomeMessage { get; set; }

        //[BindProperty]
        //public Demo.ASP.NET.Core.Model.Customers Customers { get; set; }
        private string PrivateMessage { get; set; }

        // Handler Methods  // in MVC -action method
        public void OnGet()
        {
            var customers = dbContex.Customers.ToList();


            WelcomeMessage = "Welcome to ASp.net Core ";
            PrivateMessage = "Private Message";

            //Customers = new Model.Customers()
            //{
            //    Id = 1,
            //    Email = "Ms@abc.com",
            //    Name = "Virat"
            //};
        }

        public void OnPost()
        {

        }
    }
}
