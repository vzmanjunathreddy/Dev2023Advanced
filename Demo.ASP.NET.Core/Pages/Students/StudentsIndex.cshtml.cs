using Demo.ASP.NET.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Demo.ASP.NET.Core.Pages.Students
{

    public class StudentsIndex : PageModel
    {

        public string StudentDetails { get; set; }
        [BindProperty]
        public Student? Student { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPostSubmitStudentData(Student student)
        {

            this.StudentDetails = $"Name of the Student is  {student.FirstName},{student.LastName}   <br/> " +
                                  $"Gender is  :{student.Country} <br/> " +
                                  $"Course Registered is  :{student.Country}  <br/>  " +
                                  $"Country is  :{student.Country}" +
                                  $"I Agree terms and Conditons  : {student.AgreeTermsandConditions}";

            return RedirectToPage("ThankUPage", "StudentDetails",new { StudentDetails = StudentDetails });
             
        }
    }
}


