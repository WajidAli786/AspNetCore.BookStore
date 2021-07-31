using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "Controller";
        }
    }
}
