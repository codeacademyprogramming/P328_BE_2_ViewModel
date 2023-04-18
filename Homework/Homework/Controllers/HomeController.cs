using Microsoft.AspNetCore.Mvc;

namespace Homework.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            //ViewResult view = new ViewResult();
            //view.ViewName = "Index";

            return View();
        }

        public ViewResult About()
        {
            return View();
        }

        public ViewResult Contact()
        {
            return View();
        }
    }
}
