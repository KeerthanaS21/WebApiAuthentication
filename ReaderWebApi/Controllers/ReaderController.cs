using Microsoft.AspNetCore.Mvc;

namespace ReaderWebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ReaderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
