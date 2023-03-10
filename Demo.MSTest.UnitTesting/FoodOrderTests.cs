using Demo.ASP.NET.Core.Data;
using Demo.ASP.NET.Core.Interfaces;
using Demo.ASP.NET.Core.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MSTest.UnitTesting
{
    [TestClass]
    public class FoodOrderTests
    {
        TestContext testContext = null;

        [TestMethod]
        public async void Getda()
        {
            testContext= new TestContext();

         //   var result =await foodOrderService.GetCustomers();
            Assert.IsTrue(true);
        }
    }
}
