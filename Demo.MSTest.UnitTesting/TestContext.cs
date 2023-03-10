using Demo.ASP.NET.Core.Data;
using Demo.ASP.NET.Core.Interfaces;
using Demo.ASP.NET.Core.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.MSTest.UnitTesting
{
    [TestClass]
    public class TestContext
    {
        public IFoodOrdersService foodOrderService;
        private ADVFoodDbContext _dbContext;
        private UnitofWork unitofWork;
        private const string connectionString = @"Data Source=.;Initial Catalog=ADVFoodDb;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;";

        public TestContext()
        {
            var dbContextOptions = new DbContextOptionsBuilder<ADVFoodDbContext>().UseSqlServer(connectionString).Options;
            _dbContext = new ADVFoodDbContext(dbContextOptions);
            unitofWork = new UnitofWork(_dbContext);

            foodOrderService = new FoodOrdersService(unitofWork);
        }

        [TestMethod]
        public async Task  GetResult()
        {
            var result =await foodOrderService.GetOrders();
            Assert.IsTrue(true);
        }

    }
}

