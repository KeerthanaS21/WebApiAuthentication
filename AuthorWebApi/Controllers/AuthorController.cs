using AuthorWebApi.Models;
using AuthorWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuthorWebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class AuthorController : Controller
    {
        public static List<Author> authors = new List<Author>()
        {
            new Author { AuthorId = 1, AuthorName = "Anu", City = "Acity"},
            new Author { AuthorId = 2, AuthorName = "Banu", City = "Bcity"},
            new Author { AuthorId = 3, AuthorName = "Aira", City = "Ccity"}
        };

        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IEnumerable<Author> GetAuthors()
        {
            return authors; 
        }

        [HttpPost]
        public ActionResult<string> AddAuthor([FromBody] List<Author> authorList)
        {
            string result = _authorService.AddAuthor(authors, authorList);
            return Ok(result);
        }
    }
}
