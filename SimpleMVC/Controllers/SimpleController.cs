using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class SimpleController : Controller
    {
        // GET: SimpleController
        private List<Person>? persons;
        public ActionResult Index()
        {
            // SimpleExemple exemples = new SimpleExemple("trangle", 3.4f, 4.6f);
            persons = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 25, IdIncome = 1, IdSpending = 1},
                new Person() {Id = 2, FirstName = "Ewa", LastName = "Farna", Age = 54, IdIncome = 2, IdSpending = 2},
                new Person() {Id = 3, FirstName = "Stanisław", LastName = "Kamiński", Age = 45, IdIncome = 3, IdSpending = 3},
                new Person() {Id = 5, FirstName = "Janina", LastName = "Kowalskia", Age = 17, IdIncome = 4, IdSpending = 4},
                new Person() {Id = 6, FirstName = "Jurek", LastName = "Nowak", Age = 12, IdIncome = 5, IdSpending = 5}

            };

            
            //  exemples.Add(new SimpleExemple("trangle",3,5)); 
            return View(persons);
        }

        // GET: SimpleController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SimpleController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SimpleController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SimpleController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SimpleController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SimpleController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SimpleController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
