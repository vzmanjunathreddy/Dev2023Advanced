using Demo.Dependency.Injection.Service.LifeTimes.Interfaces;
using Demo.Dependency.Injection.Service.LifeTimes.Models;
using System.Collections.Generic;

namespace Demo.Dependency.Injection.Service.LifeTimes.Data
{
    public class OrdersRepository : IOrdersRepository
    {
        public OrdersRepository()
        {

        }

        public async Task<IEnumerable<Orders>> GetListofOrders()
        {
            // Object reference error 
            return GetOrders();
        }

        public async Task<int> GetCountofOrders()
        {
            int countofOrders = 0;
            try
            {
                countofOrders = GetOrders().Count();
            }
            catch (Exception ex)
            {

            }
            return countofOrders;
        }

        private IEnumerable<Orders> GetOrders()
        {
            List<Orders> ordersCollection = new();
            //  List<Orders> ordersCollection = new List<Orders>(); same as above
            try
            {


                ordersCollection.Add(new Orders() { OrderId = 1, CreatedDate = DateTime.Now, price = 10.40, Quantity = 2 });
                ordersCollection.Add(new Orders() { OrderId = 2, CreatedDate = DateTime.Now, price = 30.40, Quantity = 20 });
                ordersCollection.Add(new Orders() { OrderId = 3, CreatedDate = DateTime.Now, price = 40.40, Quantity = 12 });
                ordersCollection.Add(new Orders() { OrderId = 4, CreatedDate = DateTime.Now, price = 40, Quantity = 32 });
                ordersCollection.Add(new Orders() { OrderId = 5, CreatedDate = DateTime.Now, price = 40, Quantity = 82 });
                ordersCollection.Add(new Orders() { OrderId = 6, CreatedDate = DateTime.Now, price = 10, Quantity = 27 });
            }
            catch (Exception ex)
            {
                //logging needs to done
            }
            return ordersCollection;
        }
    }
}
