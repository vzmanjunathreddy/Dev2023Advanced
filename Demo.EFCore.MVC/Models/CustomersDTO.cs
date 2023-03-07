namespace Demo.EFCore.MVC.Models
{
    public class CustomersDTO
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        //public virtual ICollection<Orders> Orders { get; set; }

    }
}
