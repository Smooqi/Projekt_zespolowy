using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Data;
using SimpleMVC.Models;


namespace SimpleMVC.Controllers
{
    public class AccountController : Controller
    {

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
       }
     
        public IActionResult LoginErr()
        {
            return View("LoginErr");
        }
    }

}
