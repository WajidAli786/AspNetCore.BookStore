﻿using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.BookStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
