using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class Raport : Controller
    {
        public IActionResult Index()
        {
            var model = new ChartViewModel
            {
                Labels = new List<string> { "Expense A", "Expense B", "Expense C" },
                Data = new List<int> { GenerateRandomValue(), GenerateRandomValue(), GenerateRandomValue() }
            };

            return View(model);
        }

        private int GenerateRandomValue()
        {
            return new Random().Next(1, 100);
        }
    }
}
