using Lil.Search.Controllers;
using Lil.Search.Interfaces;
using Lil.Search.Tests.FakeServices;
using Microsoft.AspNetCore.Mvc;

namespace Lil.Search.Tests
{
    [TestClass]
    public class SearchTest
    {
        [TestMethod]
        public async Task Test_Search_When_Exist()
        {
            ICustomersService customersService = new FakeCustomersService();
            ISalesService salesService = new FakeSalesService();
            IProductsService productsService = new FakeProductsService();
            var searchController = new SearchController(customersService, productsService, salesService);
            var result = await searchController.SearchAsync("1");
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
    }
}