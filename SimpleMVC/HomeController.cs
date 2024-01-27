using Microsoft.AspNetCore.Mvc;

namespace SimpleMVC
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
