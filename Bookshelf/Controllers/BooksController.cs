using BookshelfAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookshelfAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Atomic Habits", Author = "James Clear", Year = 2018 },
            new Book { Id = 2, Title = "The Fourth Child", Author = "Jessica Winter", Year = 2021 },
            new Book { Id = 3, Title = "The Distance Home", Author = "Paula Saunders", Year = 2018 }
        };

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(books);
        }

        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);
            return Ok(book);
        }
    }
}
