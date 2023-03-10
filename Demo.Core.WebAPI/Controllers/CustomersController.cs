using Demo.Core.CustomersAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;

namespace Demo.Core.CustomersAPI.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(ILogger<CustomersController> logger)
        {
            _logger = logger;
        }

        #region old code
        //public IEnumerable<Customers> GetListofCustomers()
        //{
        //    List<Customers> customersCollection = new();

        //    try
        //    {
        //     customersCollection.Add(
        //      new Customers()
        //      {
        //          City = "Hyd",
        //          CreatedBy = "Yuvi",
        //          CreatedDate = DateTime.UtcNow,
        //          Email = "yvu@abc.com",
        //          ModifieBy = "bcc@abc.com",
        //          ModifiedDate = DateTime.UtcNow
        //      });
        //     customersCollection.Add(
        //                      new Customers()
        //                      {
        //                          City = "Hyd2",
        //                          CreatedBy = "Yuvi2",
        //                          CreatedDate = DateTime.UtcNow,
        //                          Email = "yvu@abc.com",
        //                          ModifieBy = "bcc@abc.com",
        //                          ModifiedDate = DateTime.UtcNow
        //                      });
        //        customersCollection.Add(new Customers()
        //        {
        //            City = "Hyd3",
        //            CreatedBy = "Yuvi",
        //            CreatedDate = DateTime.UtcNow,
        //            Email = "yvu@abc.com",
        //            ModifieBy = "bcc@abc.com",
        //            ModifiedDate = DateTime.UtcNow
        //        });
        //    }
        //    catch (Exception ex)
        //    {

        //    }

        //    return customersCollection;
        //}

        #endregion 


        [HttpGet]
        [Route("getorders")]
        public Orders GetOrderDetails()
        {

            try
            {
                var claimsUser = HttpContext.User.Claims.Where(x => x.Type == "UserName").Select(x => x.Value).First();

                var order = Orders.GetOrders();
                var customerName = order.customerName;

                if (customerName == claimsUser)
                {
                    return order;
                }

                return order;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }


}