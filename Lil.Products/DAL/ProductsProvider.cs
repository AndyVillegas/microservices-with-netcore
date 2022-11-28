using Lil.Products.Models;

namespace Lil.Products.DAL
{
    public class ProductsProvider : IProductsProvider
    {
        private List<Product> _products = new List<Product>();
        public ProductsProvider()
        {
            for (int i = 0; i < 100; i++)
            {
                _products.Add(new Product
                {
                    Id = (i + 1).ToString(),
                    Name = $"Producto {i + 1}",
                    Price = i*3.14,
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
