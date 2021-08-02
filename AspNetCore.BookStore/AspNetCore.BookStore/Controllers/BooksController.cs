using AspNetCore.BookStore.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.BookStore.Controllers
{
    public class BooksController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BooksController()
        {
            _bookRepository = new BookRepository();
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View(model: data);
        }

        public IActionResult GetBook(int id)
        {
            var data = _bookRepository.GetBookById(bookId: id);
            return View(model: data);
        }
    }
}
