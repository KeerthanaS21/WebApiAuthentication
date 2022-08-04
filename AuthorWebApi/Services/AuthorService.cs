using AuthorWebApi.Models;
using System.Text;

namespace AuthorWebApi.Services
{
    public class AuthorService : IAuthorService
    {
        public string AddAuthor(List<Author> authorList, List<Author> author)
        {
            StringBuilder resultString = new StringBuilder();

            foreach (var item in author)
            {
                authorList.Add(item);
                resultString.Append($"Added Author{item.AuthorName}\n");
            }

            return resultString.ToString();
        }
    }
}
