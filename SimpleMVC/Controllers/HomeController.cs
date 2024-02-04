using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using SimpleMVC.Data;
using SimpleMVC.Models;
using System.Diagnostics;
using SimpleMVC.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }



        public IActionResult Index(Osoba os)
        {
            var viewModel = new HomeViewModelOne
            {
                Imie = os.Imie,//HttpContext.User.Identity.Name,
                PrzychodStaly = db.PrzychodyStale.FirstOrDefault(x => x.Id == os.IdPrzychodStaly),
                PrzychodZmienny = db.PrzychodyZmienne.FirstOrDefault(x => x.Id == os.IdPrzychodZmienny),
                WydatekStaly = db.WydatkiStale.FirstOrDefault(x => x.Id == os.IdWydatekStaly),
                WydatekZmienny = db.WydatkiZmienne.FirstOrDefault(x => x.Id == os.IdWydatekZmienny),
                OszczednosciStale = db.OszczednosciStale.FirstOrDefault(x => x.Id == os.IdOszczednosciStale),
                OszczednosciZmienne = db.OszczednosciZmienne.FirstOrDefault(x => x.Id == os.IdOszczednosciZmienne),
                Osoba = os // Tutaj zainicjalizuj obiekt Osoba
            };

            return View(viewModel);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Niezalogowany()
        {
            return RedirectToAction("LoginErr", "Account");
        }

        public IActionResult User(Osoba os)
        {
            var viewModel = new HomeViewModel
            {
                ImieUzytkownika = HttpContext.User.Identity.Name,
                PrzychodyStale = db.PrzychodyStale.ToList(),
                PrzychodyZmienne = db.PrzychodyZmienne.ToList(),
                WydatkiStale = db.WydatkiStale.ToList(),
                WydatkiZmienne = db.WydatkiZmienne.ToList(),
                OszczednosciStale = db.OszczednosciStale.ToList(),
                OszczednosciZmienne = db.OszczednosciZmienne.ToList(),
                Osoba = os
            };

            return View("../Home/Index", viewModel);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult EditSpending(string category, float newValue)
        {
            // Udawana operacja edycji wydatku o danej kategorii
            // Poni¿ej znajdziesz kod przyk³adowy - tutaj mo¿esz dostosowaæ go do swojej implementacji

            // Zamiast rzeczywistej operacji na bazie danych
            // var spending = dbContext.Spending.FirstOrDefault(s => s.Category == category);
            // if (spending != null)
            // {
            //     spending.Value = newValue;
            //     dbContext.SaveChanges();
            //     return RedirectToAction("Index"); // Przekierowanie do g³ównej strony po edycji
            // }
            // else
            // {
            //     return RedirectToAction("Index");
            // }

            // Udawane zwrócenie wyniku
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteSpending(string category)
        {
            // Udawana operacja usuwania wydatku o danej kategorii
            // Poni¿ej znajdziesz kod przyk³adowy - tutaj mo¿esz dostosowaæ go do swojej implementacji

            // Zamiast rzeczywistej operacji na bazie danych
            // var spending = dbContext.Spending.FirstOrDefault(s => s.Category == category);
            // if (spending != null)
            // {
            //     dbContext.Spending.Remove(spending);
            //     dbContext.SaveChanges();
            //     return RedirectToAction("Index"); // Przekierowanie do g³ównej strony po usuniêciu
            // }
            // else
            // {
            //     return RedirectToAction("Index");
            // }

            // Udawane zwrócenie wyniku
            return RedirectToAction("Index");
        }
    }
}
