using Lil.Sales.Controllers;
using Lil.Sales.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Sales.Tests
{
    [TestClass]
    public class SalesTest
    {
        [TestMethod]
        public void Test_Get_Async_When_Exist()
        {
            var salesProvider = new SalesProvider();
            var salesController = new SalesController(salesProvider);

            var result = salesController.GetAsync("1").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Test_Get_Async_When_Not_Exist()
        {
            var salesProvider = new SalesProvider();
            var salesController = new SalesController(salesProvider);

            var result = salesController.GetAsync("99").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}