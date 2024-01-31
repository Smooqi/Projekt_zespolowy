using Microsoft.AspNetCore.Mvc;

namespace SimpleMVC.Controllers
{
    public class RejestrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
