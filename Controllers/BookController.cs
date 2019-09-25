using System.Collections.Generic;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace ODataSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        public BookController(LibraryDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [EnableQuery]
        public IEnumerable<Book> GetBooks()
        {
            return _context.Books;
        }
    }
}