﻿namespace Demo.ASP.NET.Core.Models
{
    public class OrdersDTO
    {
        public DateTime CreatedDate { get; set; }
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public int CustomerId { get; set; }
    }
}