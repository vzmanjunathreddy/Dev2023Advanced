using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace Demo.ASP.NET.Core.Pages.Customers
{
    public class CustomersModel : PageModel
    {

        [BindProperty]
        public string WelcomeMessage { get; set; }

        //[BindProperty]
        //public Demo.ASP.NET.Core.Model.Customers Customers { get; set; }
        private string PrivateMessage { get; set; }

        // Handler Methods 
        public void OnGet()
        {
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
