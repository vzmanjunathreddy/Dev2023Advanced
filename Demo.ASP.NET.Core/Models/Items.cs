namespace Demo.ASP.NET.Core.Models
{
    public class Items
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
