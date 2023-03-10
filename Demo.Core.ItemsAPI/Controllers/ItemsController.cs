using Demo.Core.ItemsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Demo.Core.ItemsAPI.Interfaces;

namespace Demo.Core.ItemsAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsService _itemsService;

        public ItemsController(IItemsService itemsService)
        {
            _itemsService = itemsService;
        }


        [HttpGet]
        [Route("getitems")]
        public async Task<Orders> GetOrderItems()
        {
            var claimsUser = HttpContext.User.Claims;

            if(claimsUser != null)
            {
                //enable logout

              
                // 
            }
           else
            {
                // enable login
            }

            var orders=await _itemsService.GetOrderItems();

            return orders;

        }
      
    } 

}


