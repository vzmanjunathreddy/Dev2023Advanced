namespace Demo.Core.CustomersAPI.Models
{
    public class Base
    {
        public DateTime CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifieBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
