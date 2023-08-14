using Microsoft.AspNetCore.Mvc;

namespace StudentManagerASP.NET.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
