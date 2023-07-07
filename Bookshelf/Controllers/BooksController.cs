using BookshelfAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookshelfAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // A static list to store the books

        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Atomic Habits", Author = "James Clear", Year = 2018 },
            new Book { Id = 2, Title = "The Fourth Child", Author = "Jessica Winter", Year = 2021 },
            new Book { Id = 3, Title = "The Distance Home", Author = "Paula Saunders", Year = 2018 }
        };

        // GET: api/Books

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            // Return all the books as a response
            return Ok(books);
        }

        // POST: api/Books

        [HttpPost]
        public IActionResult AddBook([FromBody] Book book)
        {
            // Assign a new ID to the book based on the count of existing books
            book.Id = books.Count + 1;

            // Add the book to the list
            books.Add(book);

            // Return the newly added book as a response
            return Ok(book);
        }
    }
}
