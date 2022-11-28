using Lil.Search.Interfaces;
using Lil.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lil.Search.Tests.FakeServices
{
    internal class FakeSalesService : ISalesService
    {
        private List<Order> _orders = new List<Order>();
        public FakeSalesService()
        {
            _orders.Add(new Order
            {
                Id = "0001",
                CustomerId = "1",
                OrderDate = DateTime.UtcNow.AddMonths(-1),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0001", Id = 1, Price = 50, ProductId = "1", Quantity = 1},
                    new OrderItem(){ OrderId = "0001", Id = 2, Price = 50, ProductId = "2", Quantity = 1}
                }
            });
            _orders.Add(new Order
            {
                Id = "0002",
                CustomerId = "2",
                OrderDate = DateTime.UtcNow.AddMonths(-1),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0002", Id = 1, Price = 50, ProductId = "1", Quantity = 1},
                    new OrderItem(){ OrderId = "0002", Id = 2, Price = 50, ProductId = "4", Quantity = 1}
                }
            });
            _orders.Add(new Order
            {
                Id = "0003",
                CustomerId = "2",
                OrderDate = DateTime.UtcNow.AddMonths(-1),
                Total = 100,
                Items = new List<OrderItem>()
                {
                    new OrderItem(){ OrderId = "0003", Id = 1, Price = 50, ProductId = "5", Quantity = 1}
                }
            });
        }
        public Task<ICollection<Order>> GetAsync(string customerId)
        {
            var orders = _orders.Where(o => o.CustomerId == customerId).ToList();
            return Task.FromResult(orders as ICollection<Order>);
        }
    }
}
