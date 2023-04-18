using Homework.Models;
using System.Collections.Generic;

namespace Homework.ViewModels
{
    public class ProductViewModel
    {
        public List<Brand> Brands { get; set; } 
        public List<Product> Products { get; set; }
    }
}
