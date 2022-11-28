using Lil.Search.Interfaces;
using Lil.Search.Models;

namespace Lil.Search.Tests.FakeServices
{
    internal class FakeProductsService : IProductsService
    {
        private List<Product> _products = new List<Product>();
        public FakeProductsService()
        {
            for (int i = 0; i < 100; i++)
            {
                _products.Add(new Product
                {
                    Id = (i + 1).ToString(),
                    Name = $"Producto {i + 1}",
                    Price = i * 3.14,
                });
            }
        }

        public Task<Product?> GetAsync(string id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(product);
        }
    }
}
