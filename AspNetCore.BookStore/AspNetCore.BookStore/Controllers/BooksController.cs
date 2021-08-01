using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.BookStore.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllBooks()
        {
            return View();
        }
    }
}
