namespace Demo.MVC.EF.Models
{
    public class ItemsDTO
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
