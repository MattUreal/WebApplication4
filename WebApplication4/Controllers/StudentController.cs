using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
