using Demo.MVC.EF.Interfaces;
using Demo.MVC.EF.Models;
using System.Collections.Generic;

namespace Demo.MVC.EF.Service
{
    public class FoodOrdersService : IFoodOrdersService
    {
        private readonly IUnitofWork _unitofWork;

        public FoodOrdersService(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;

        }

        public async Task<bool> AddfoodOrder(CustomersDTO customers)
        {
            try
            {
                var customer = new Customers()
                {

                    Name = "UnitofWorkCustomer",
                    City = "Jarkhand",
                    Email = "uow@gmail.com",
                    Contact = "123645"

                };

                var isCustomerAdded = await _unitofWork.CustomersRepository.AddEntity(customer);

                var orders = new Orders()
                {

                    CustomerId = 3,
                    Quantity = 2,
                    CreatedDate = DateTime.Now,
                    TotalAmount = 100
                };

                var isordersAdded = await _unitofWork.OrdersRepository.AddEntity(orders);

                var items = new Items()
                {

                    Name = "Idly",
                    Category = "Breakfast",
                    Price = 30
                };
                var isitemsAdded = await _unitofWork.ItemsRepository.AddEntity(items);

                _unitofWork.SaveChangestoDB();
            }
            catch (Exception ex)
            {

            }
            return true;
        }

        public Task<bool> AddRangeofCustomers(IEnumerable<CustomersDTO> customers)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomers(int customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ItemsDTO>> GetAllItemsItems()
        {
            List<ItemsDTO> itemsCollection = null;
            try
            {
                var items = await _unitofWork.ItemsRepository.GetAll();

                itemsCollection = new List<ItemsDTO>();

                itemsCollection = items.Select(x => new ItemsDTO()
                {
                    Id = x.Id,
                    Category = x.Category,
                    ImageUrl = "",
                    Name = x.Name,
                    Price = x.Price
                }).ToList();

            }
            catch (Exception ex)
            {

            }
            return itemsCollection;
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

        public ItemsDTO GetItemById(int id)
        {


            var item = _unitofWork.ItemsRepository.GetById(id);

            ItemsDTO itemDTO = new ItemsDTO()
            {
                Id = item.Id,
                Category = item.Category,
                ImageUrl = "",
                Name = item.Name,
                Price = item.Price
            };

            return itemDTO;



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
