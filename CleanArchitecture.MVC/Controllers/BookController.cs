using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.MVC.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetBooks();
            return View(model);
        }
    }
}
