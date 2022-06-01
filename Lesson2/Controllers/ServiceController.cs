using Microsoft.AspNetCore.Mvc;

namespace Lesson2.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
