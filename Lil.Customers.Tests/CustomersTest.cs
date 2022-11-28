using Lil.Customers.Controllers;
using Lil.Customers.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Customers.Tests
{
    [TestClass]
    public class CustomersTest
    {
        [TestMethod]
        public void Test_Get_Async_When_Exist()
        {
            var customersProvider = new CustomersProvider();
            var customersController = new CustomersController(customersProvider);

            var result = customersController.GetAsync("1").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Test_Get_Async_When_Not_Exist()
        {
            var customersProvider = new CustomersProvider();
            var customersController = new CustomersController(customersProvider);

            var result = customersController.GetAsync("99").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}