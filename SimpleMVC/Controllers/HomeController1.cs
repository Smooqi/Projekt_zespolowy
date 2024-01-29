using Microsoft.AspNetCore.Mvc;

namespace SimpleMVC.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
