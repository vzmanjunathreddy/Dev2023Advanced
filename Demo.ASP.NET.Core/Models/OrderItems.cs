namespace Demo.ASP.NET.Core.Models
{
    public class OrderItems
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public Orders Orders { get; set; }

        public int ItemsId { get; set; }
        public Items Items { get; set; }


    }
}
