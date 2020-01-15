using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLApi.Models;

namespace GraphQLApi.Context
{
    public class YvzContext
    {
        private readonly List<Brand> _brands = new List<Brand>();
        private readonly List<Product> _products = new List<Product>();

        public YvzContext()
        {
            for (int i = 0; i < 10; i++)
            {
                _brands.Add(new Brand
                {
                    Id = i,
                    Name = $"Brand-{i}"
                });
            }

            for (int i = 0; i < 53; i++)
            {
                Random random = new Random();
                _products.Add(new Product
                {
                    Id = i,
                    Name = $"Product-{i}",
                    Price = random.Next(10),
                    Brand = _brands.FirstOrDefault(x => x.Id == random.Next(1, 10))
                });
            }
        }

        public List<Brand> GetBrands()
        {
            return _brands;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public List<Product> GetProductsByBrandId(int brandId)
        {
            return _products.Where(x => x.Brand?.Id == brandId).ToList();
        }
    }
}