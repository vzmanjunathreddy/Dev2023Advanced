using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.MVC.Models;
using System.Collections.Generic;

namespace Demo.EFCore.GenericRepository.Service
{
    public class FoodOrdersService : IFoodOrdersService
    {
        private readonly ICustomersRepository _customerRepository;
        private readonly IOrdersRepository _ordersRepository;
        private readonly IItemsRepository _itemsRepository;
        public FoodOrdersService(ICustomersRepository customerRepository, IOrdersRepository ordersRepository, IItemsRepository itemsRepository)
        {
            _customerRepository = customerRepository;
            _ordersRepository = ordersRepository;
            _itemsRepository = itemsRepository;
        }

        public Task<bool> AddfoodOrder(CustomersDTO customers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomers(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomersDTO>> GetCustomers()
        {
            IEnumerable<Customers> customersCollection = null;

            List<CustomersDTO> newCustomersCollection = new();
            try
            {
                newCustomersCollection = new List<CustomersDTO>();

                var customers = await _customerRepository.GetAll();

                // customersCollection = customers!=null? customers.ToList():null;

                newCustomersCollection = customers.Select(x => new CustomersDTO
                {
                    Name = x.Name,
                    City = x.City,
                    Contact = x.Contact,
                    Email = x.Email

                }).ToList();


                //foreach(var customer in customers)
                //{

                //    customersCollection.Add(new CustomersDTO()
                //    {
                //        City = customer.City,
                //        Contact = customer.Contact,
                //        Email = customer.Email,
                //        Name = customer.Name
                //    });
                //}


            }
            catch (Exception ex)
            {

            }
            return newCustomersCollection;
        }

        public async Task<IEnumerable<OrdersDTO>> GetOrders()
        {
            return _ordersRepository.GetAll().Result.Select(x => new OrdersDTO
            {
                CreatedDate = x.CreatedDate,
                CustomerId = x.CustomerId,
                Quantity = x.Quantity,
                TotalAmount = x.TotalAmount
            });
        }

        public Task<bool> UpdateCustomers(CustomersDTO customers)
        {
            throw new NotImplementedException();
        }
    }
}
