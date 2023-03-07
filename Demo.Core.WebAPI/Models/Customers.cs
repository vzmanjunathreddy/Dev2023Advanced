using Demo.Core.CustomersAPI.Controllers;

namespace Demo.Core.CustomersAPI.Models
{
    public class Customers : Base
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string? Email { get; set; }

    }
}