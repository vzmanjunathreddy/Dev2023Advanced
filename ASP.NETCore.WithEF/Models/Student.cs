using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP.NETCore.WithEF.Models
{

    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Kindly enter the First name of the user which you are missing")]
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool AgreeTermsandConditions { get; set; }
        public Gender Gender { get; set; }
        public string? Course { get; set; }
        public string? Country { get; set; }

    }

    public enum Gender
    {
        Male = 1, Female
    }
}
