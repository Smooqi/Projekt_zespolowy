using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class AccountController : Controller
    {
        
            private bool IsValidUser(string username, string password)
            {
            //var user = Users.userList.SingleOrDefault(u => u.UserName == username);
            bool taknie = false;
            foreach (var testc in Users.userList)
            {
                if ((username == testc.UserName) && (password == testc.Password))
                {
                    taknie = true; // Użytkownik istnieje i hasło jest poprawne
                    break;
                }
                else
                    taknie = false;
            }
            if(taknie)
                return true;
            else
                return false;
           // return false;
            //      if (user != null)
            //   {
            // Sprawdź hasło
            //if (password.Equals(user.Password))
            //if (password == "pass1")
            //{
            //    }
        }
        //}

        // return false; // Użytkownik nie istnieje lub hasło jest niepoprawne
    
            //}
                    
        /*
                [HttpPost]
                public IActionResult Index()
                {
                    return View();
                }

                //[Authorize]
                [HttpGet]
                public IActionResult Login(Users us)
                {

                    if (ModelState.IsValid)
                    {
                        // Sprawdź dane logowania i autoryzuj użytkownika
                        if (IsValidUser(us.UserName, us.Password))
                        {


                            return RedirectToAction("Index", "Simple");
                        }
                        else
                        {
                            // Nieprawidłowe dane logowania
                            ViewData["ErrorMessage"] = "Invalid user name or password.";
                        }
                    }

                        return View(us);
                }

                        public IActionResult Logout()
                        {
                            // Wyloguj użytkownika
                            // ...

                            return RedirectToAction("Index", "Home");
                        }
                */
        [HttpPost]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(Users model)
        {
            // Sprawdź dane logowania i autoryzuj użytkownika
            if (IsValidUser(model.UserName, model.Password))
            {
                ViewData["ErrorMessage"] = "Jest ok";
                // Pomyślna autoryzacja - przekieruj gdzie trzeba
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Nieprawidłowe dane logowania
                ViewData["ErrorMessage"] = "Invalid username or password.";
                return View(model);
            }
        }
        public IActionResult LoginErr()
        {
            return View();
        }
    }
}
