using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class SimpleController : Controller
    {
        // GET: SimpleController
        private List<Person>? persons;
        private List<Income>? incomes;
        private List<Spending>? spendings;
      
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

            incomes = new List<Income>()
            {
                new Income() {Id = 1, Date = DateTime.Now, Rental = 0, Salary = 4400, SideJob = 500},
                new Income() {Id = 1, Date = DateTime.UtcNow, Rental = 0, Salary = 400, SideJob = 0},
                new Income() {Id = 1, Date = DateTime.Now, Rental = 2000, Salary = 14400, SideJob = 1500},
                new Income() {Id = 1, Date = DateTime.UtcNow, Rental = 1000, Salary = 2400, SideJob = 500},
                new Income() {Id = 1, Date = DateTime.Now, Rental = 0, Salary = 3400, SideJob = 0}
            };

            spendings = new List<Spending>()
            {
                new Spending() {Id = 1, Bills = 2000, Drugs = 0, Food = 800, Holidays = 3000, Loans = 500, Unexpected = 2000, Date = DateTime.Now },
                new Spending() {Id = 2, Bills = 5000, Drugs = 500, Food = 1000, Holidays = 3000, Loans = 500, Unexpected = 500, Date = DateTime.Now },
                new Spending() {Id = 3, Bills = 13000, Drugs = 0, Food = 1500, Holidays = 13000, Loans = 500, Unexpected = 1000, Date = DateTime.Now },
                new Spending() {Id = 4, Bills = 0, Drugs = 200, Food = 500, Holidays = 0, Loans = 500, Unexpected = 0, Date = DateTime.Now },
                new Spending() {Id = 5, Bills = 0, Drugs = 0, Food = 0, Holidays = 0, Loans = 500, Unexpected = 0, Date = DateTime.Now },


            };


            //  exemples.Add(new SimpleExemple("trangle",3,5)); 
            return View(persons);
        }

        // GET:SimpleController/Details/5
        [HttpPost]
        public ActionResult Details(int id)
        {
            if (id == null)
                return BadRequest("Nie ma takiej osoby w bazie");

           // var oneperson = persons.
            Person persons = new Person();
           if((ModelState.IsValid)&&(persons.Id == id))
            {
                return View(persons.Id);
            }
           else
            return RedirectToAction("Index");
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
