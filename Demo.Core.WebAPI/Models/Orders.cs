namespace Demo.Core.CustomersAPI.Models
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string OrderName { get; set; }
        public string customerName { get; set; }

        public static Orders GetOrders()
        {
            Orders orders = new()
            {
                OrderName = "Pizza",
                customerName = "Admin",
                OrderId = 12
            };
            return orders;
        }
    }
}
