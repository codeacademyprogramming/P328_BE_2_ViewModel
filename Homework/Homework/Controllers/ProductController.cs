using Homework.DataAccess;
using Homework.Models;
using Homework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Homework.Controllers
{
    public class ProductController : Controller
    {

        //public RedirectToActionResult Index(int id)
        //{
        //    ViewData["id"] = id;
        //    ViewBag.Id = 55;
        //    TempData["Id"] = 67;

        //    return RedirectToAction("Detail");
        //}
        //public ViewResult Detail(int id)
        //{
        //    ViewData["id"] = id;
        //    //ViewBag.Id = id;
        //    TempData["Id"] = id;

        //    return View();
        //}

        public ViewResult Index()
        {
            List<Brand> brands = Data.Brands;
            List<Product> products = Data.Products;

            //ViewBag.Products = products;
            //ViewBag.Brands = brands;

            ProductViewModel productVM = new ProductViewModel
            {
                Brands = brands,
                Products = products
            };

            return View(productVM);
        }

        public ViewResult Detail(int id)
        {
            List<Product> products = Data.Products;

            Product pr = products.Find(x => x.Id == id);

            //ViewBag.Product = pr;

            return View(pr);
        }



    }
}
