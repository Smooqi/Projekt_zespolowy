using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Data;
using SimpleMVC.Models;
using SimpleMVC.ViewModels;


namespace SimpleMVC.Controllers
{
    public class AccountController : Controller
    {

        private readonly ApplicationDbContext db;

        public AccountController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult StronaLogowania()
        {
            return View("../Account/Login");
        }

        public Osoba PobierzOsobe(Dostep d)
        {
            Osoba record = db.Osoby.FirstOrDefault(x => x.IdDostepu == d.Id);
            if (record == null)
                return null;
            else
            {
                db.Entry(record);
                return record;
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Dostep d)
        {
            var dostep = db.Dostepy.FirstOrDefault(x => (x.Login == d.Login) && (x.Haslo == d.Haslo));

            if (dostep != null)
            {
                var osoba = PobierzOsobe(dostep);
                /*        string imieUzytkownika = osoba?.Imie;

                        var viewModel = new HomeViewModel
                        {
                            ImieUzytkownika = imieUzytkownika,
                            PrzychodyStale = db.PrzychodyStale.ToList(),
                            PrzychodyZmienne = db.PrzychodyZmienne.ToList(),
                            WydatkiStale = db.WydatkiStale.ToList(),
                            WydatkiZmienne = db.WydatkiZmienne.ToList(),
                            OszczednosciStale = db.OszczednosciStale.ToList(),
                            OszczednosciZmienne = db.OszczednosciZmienne.ToList(),
                            Osoba = osoba
                        };*/

                return RedirectToAction("Index", "Home", /*viewModel);*/osoba);
            }
            else
            {
                return RedirectToAction("Niezalogowany", "Home", "test nie ok");
            }
        }

        public IActionResult Logout(Dostep us)
        {
            us.Login = string.Empty;
            us.Haslo = string.Empty;
            return RedirectToAction("StronaLogowania", "Account");
        }

        public IActionResult LoginErr()
        {
            return View("LoginErr");
        }

    }
}
