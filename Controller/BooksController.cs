using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly FirstAPIContext _context;

        public BooksController(FirstAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetBooks()
        {
            return Ok(await _context.Books.ToListAsync());
        }
        
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        

        [HttpPost]
        public async Task<ActionResult<Book>> AddBook(Book newBook)
        {
            if (newBook == null)
                return BadRequest();

            _context.Books.Add(newBook);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBookById), new { id = newBook.Id }, newBook);
        } 
        
        
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, Book updateBook)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            book.Id = updateBook.Id;
            book.Title = updateBook.Title;
            book.Author = updateBook.Author;
            book.YearPublished = updateBook.YearPublished;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book == null)
                return NotFound();

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return NoContent();
        } 
        


    }
}

/* 
In [HttpPut("{id}")], [HttpDelete("{id}")]
    use 'IActionResult' insteasd of 'ActionResul' , 
    because here we are not returning any object.
    we're just returing status codes and this is the most appropriate way 
    to do it. 
    => take/specific the ID => {id} for the book to be updated or deleted. 

'var book = books.FirstOrDefault(x => x.Id == id);'
    => meaning: looking for the book with this ID.
*/





        // 用static，每次重新啟動伺服器（例如重新 dotnet run）就會回到初始狀態，新增的資料會消失。
        // 這表示這個 books 清單是儲存在伺服器的記憶體中，而不是資料庫或檔案系統。

        /*static private List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Book 1",
                Author = "Author 1",
                YearPublished = 2001
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Author = "Author 2",
                YearPublished = 2002
            },
            new Book
            {
                Id = 3,
                Title = "Book 3",
                Author = "Author 3",
                YearPublished = 2003
            },
            new Book
            {
                Id = 4,
                Title = "Book 4",
                Author = "Author 4",
                YearPublished = 2004
            },
            new Book
            {
                Id = 5,
                Title = "Book 5",
                Author = "Author 5",
                YearPublished = 2005
            }
        }; */


        //use dependency injection so the we access our context.
        /* 
        Go to the first method to our http get method. One main chnage that 
        we'll do in all of our methods actually is that we will make our methods
        to be asynchronous because each time we make API call or we access the database 
        as in our case we don't want the thread of our application to be blocked. 
        If you know some apps when you make something we make a request and the UI stops. 
        This is what asynchronous methods solve. So all we need to do is add async keyword here. 
        */