using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelEasy.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>
        {
            new Product { Name = "New York", Price = 25 },
            new Product { Name = "Bali", Price = 179},
            new Product { Name = "Cappadocia", Price = 95}
        }.AsQueryable<Product>();

    }
}
