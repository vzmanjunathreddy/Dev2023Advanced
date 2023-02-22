
namespace Demo.EFCore.MVC.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public int CustomerId { get;set; }
        public Customers Customers { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
