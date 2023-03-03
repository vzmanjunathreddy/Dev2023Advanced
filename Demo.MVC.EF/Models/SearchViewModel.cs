namespace Demo.MVC.EF.Models
{
    public class SearchViewModel
    {
        public IEnumerable<CustomersDTO> Customers { get; set; }

        public IEnumerable<OrdersDTO> Orders { get; set; }

        public IEnumerable<ItemsDTO> Items { get; set; }
    }
}
