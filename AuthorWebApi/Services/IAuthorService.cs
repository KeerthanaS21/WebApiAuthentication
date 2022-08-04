using AuthorWebApi.Models;

namespace AuthorWebApi.Services
{
    public interface IAuthorService
    {
        string AddAuthor(List<Author> authorList, List<Author> author);
    }
}