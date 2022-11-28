using Lil.Products.Controllers;
using Lil.Products.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void Test_Get_Async_When_Exist()
        {
            var productsProvider = new ProductsProvider();
            var productsController = new ProductsController(productsProvider);

            var result = productsController.GetAsync("1").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }

        [TestMethod]
        public void Test_Get_Async_When_Not_Exist()
        {
            var productsProvider = new ProductsProvider();
            var productsController = new ProductsController(productsProvider);

            var result = productsController.GetAsync("999").Result;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }
    }
}