﻿using Store.Domain.Entities;
using Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Tests.Repositories
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Get(IEnumerable<Guid> productsIds)
        {
            IList<Product> products = new List<Product>()
            {
                new Product("Produto 1", 10, true),
                new Product("Produto 2", 10, true),
                new Product("Produto 3", 10, true),
                new Product("Produto 4", 10, false),
                new Product("Produto 5", 10, false),
            };

            return products;
        }
    }
}
