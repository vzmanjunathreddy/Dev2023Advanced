using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;
using Demo.Dependency.Injection.Service.LifeTimes.Models;
using System.Collections.Generic;

namespace Demo.Dependency.Injection.Service.LifeTimes.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrdersRepository _ordersRepository;
        public OrderService(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public int GetOrdersCount()
        {
            int ordersCount = 0;

            try
            {
                ordersCount = _ordersRepository.GetCountofOrders().Result;
            }
            catch (Exception ex)
            {

            }
            return ordersCount;
        }

        public async Task<IEnumerable<OrdersDTO>> GetOrdersList()
        {
            IEnumerable<OrdersDTO> ordersCollection = null;
            try
            {
                var ordersData = await _ordersRepository.GetListofOrders();

                ordersCollection = ordersData.Select(x => new OrdersDTO
                {
                    CreatedDate = x.CreatedDate,
                    price = x.price,
                    Quantity = x.Quantity
                });

            }
            catch (Exception ex)
            {

            }
            return ordersCollection;

        }
    }
}
