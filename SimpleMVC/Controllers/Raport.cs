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
                Labels = new List<string> { "Wydatek A", "Wydatek B", "Wydatek C" },
                Data = new List<int> { GenerateRandomValue(), GenerateRandomValue(), GenerateRandomValue() },

                IncomeLabels = new List<string> { "Przychód C", "Przychód D", "Przychód E" },
                IncomeData = new List<int> { GenerateRandomValue(), GenerateRandomValue(), GenerateRandomValue() },

                 SavingLabels = new List<string> { "Oszczednosc F", "Oszczednosc G", "Oszczednosc H" },
                SavingData = new List<int> { GenerateRandomValue(), GenerateRandomValue(), GenerateRandomValue() },
            };

            return View(model);
        }

        private int GenerateRandomValue()
        {
            return new Random().Next(1, 100);
        }
    }
}
