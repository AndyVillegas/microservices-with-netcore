using Lil.Customers.Models;

namespace Lil.Customers.DAL
{
    public class CustomersProvider : ICustomersProvider
    {
        private List<Customer> _customers = new List<Customer>();
        public CustomersProvider()
        {
            _customers.Add(new Customer
            {
                Id = "1",
                City = "El Triunfo",
                Name = "Andy Villegas"
            });
            _customers.Add(new Customer
            {
                Id = "2",
                City = "Durán",
                Name = "Emma Matamoros"
            });
            _customers.Add(new Customer
            {
                Id = "3",
                City = "Milagro",
                Name = "Kleyner Vásconez"
            });
            _customers.Add(new Customer
            {
                Id = "4",
                City = "Naranjal",
                Name = "Génesis Luna"
            });
        }
        public Task<Customer?> GetAsync(string id)
        {
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            return Task.FromResult(customer);
        }
    }
}
