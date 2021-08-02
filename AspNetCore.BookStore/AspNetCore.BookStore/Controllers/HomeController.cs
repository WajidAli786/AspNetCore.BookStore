using Microsoft.AspNetCore.Mvc;
using System.Dynamic;

namespace AspNetCore.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            dynamic data = new ExpandoObject();
            data.Id = 1;
            data.Name = "wajid";

            ViewBag.data = data;
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
