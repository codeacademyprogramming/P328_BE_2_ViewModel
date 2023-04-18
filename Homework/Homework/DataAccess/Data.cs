using Homework.Models;
using System.Collections.Generic;

namespace Homework.DataAccess
{
    public static class Data
    {
        public static List<Brand> Brands = new List<Brand>()
        {
                new Brand{ Id = 1,Name = "Apple"},
                new Brand{ Id = 2,Name = "Samsung"},
                new Brand{ Id = 3,Name = "Toshiba"},
                new Brand{ Id = 4,Name = "Xiaomi"},
                new Brand{ Id = 5,Name = "Nokia"},
                new Brand{ Id = 6,Name = "Sony"},

        };

        public static List<Product> Products = new List<Product>()
            {
                new Product{Id = 1,Name = "Product 1",Price = 120,DiscountPercent=0},
                new Product{Id = 2,Name = "Product 2",Price = 20,DiscountPercent=0},
                new Product{Id = 3,Name = "Product 3",Price = 50,DiscountPercent=10},
                new Product{Id = 4,Name = "Product 4",Price = 10,DiscountPercent=0},
            };


    }
}
