using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Data;
using SimpleMVC.Models;


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
        /*   
                   private bool IsValidUser(string username, string password)
                   {
                       Dostep users = new Dostep();
                       if ((password == users.Haslo)&&(username == users.Login))
                           return true; 
                       else return false;

                   }

           [HttpGet]
           public IActionResult Login(Dostep us)
           {
               if (ModelState.IsValid)
               {
                   if (IsValidUser(us.Login, us.Haslo))

                       return RedirectToAction("Index", "Home");
                   else
                       return RedirectToAction("NieZalogowany", "Home");
               }
               else
               {
                   ViewData["Error"] = "Nie ma takiego uzytkownika";
                   return View("ViewData[Error]");

               }
           }

          public IActionResult Logout(Dostep us)
          {
               us.Login = string.Empty;
               us.Haslo = string.Empty;
               return RedirectToAction("StronaLogowania", "Account");
          }*/

        public Osoba PobierzOsobe(Dostep d)
        {
            //Osoba record = db.Osoby.Include(o => o.IdDostepu).FirstOrDefault(x => (x.IdDostepu == d.Id));
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
        /*
            public IActionResult StronaLogowania()
            {
                return View("../Logowanie/Logowanie");
            }*/

        [HttpPost]
        public IActionResult Login(Dostep d)
        {
            // Sprawdź, czy istnieje rekord z podanym loginem i hasłem
            var dostep = db.Dostepy.FirstOrDefault(x => (x.Login == d.Login) && (x.Haslo == d.Haslo));

            if (dostep != null)
            {
                return RedirectToAction("User", "Home", PobierzOsobe(dostep), "test ok");
            }
            else
            {
                return RedirectToAction("Niezalogowany", "Home", "test nie ok");
            }

        }

        public IActionResult LoginErr()
        {
            return View("LoginErr");
        }
    }

}
