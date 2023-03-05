using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.ASP.NET.Core.Pages.Students
{
    public class ThankUPageModel : PageModel
    {
        [BindProperty]
        public string? StudentDetails { get; set; }
        public void OnGetStudentDetails(string StudentDetails)
        {
            this.StudentDetails = StudentDetails;
        }
    }
}
