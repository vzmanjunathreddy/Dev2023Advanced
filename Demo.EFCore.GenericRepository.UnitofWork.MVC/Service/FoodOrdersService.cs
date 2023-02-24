using Demo.EFCore.GenericRepository.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Interfaces;
using Demo.EFCore.GenericRepository.Unitofwork.MVC.Models;
using System.Collections.Generic;

namespace Demo.EFCore.GenericRepository.Unitofwork.MVC.Service
{
    public class FoodOrdersService : IFoodOrdersService
    {
        private readonly IUnitofWork _unitofWork;

        public FoodOrdersService(IUnitofWork unitofWork, IOrdersRepository ordersRepository, IItemsRepository itemsRepository)
        {
            _unitofWork = unitofWork;

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

                var customers = await _unitofWork.CustomersRepository.GetAll();

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
            return _unitofWork.OrdersRepository.GetAll().Result.Select(x => new OrdersDTO
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
