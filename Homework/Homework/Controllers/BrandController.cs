using Homework.DataAccess;
using Homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Homework.Controllers
{
    public class BrandController : Controller
    {
        public ViewResult Index()
        {
            List<Brand> brands = Data.Brands;

            return View(brands);
        }
    }
}
