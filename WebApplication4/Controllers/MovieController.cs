using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
