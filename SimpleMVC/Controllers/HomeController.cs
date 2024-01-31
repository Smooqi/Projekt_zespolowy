using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Data;
using SimpleMVC.Models;
using System.Diagnostics;

namespace SimpleMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        private List<Person>? persons;
        private List<Income>? incomes;
        private List<Spending>? spendings;
        private List<Saving> savings;

        public IActionResult Index()
        {
            

            // SimpleExemple exemples = new SimpleExemple("trangle", 3.4f, 4.6f);
            persons = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 35, IdIncome = 1, IdSpending = 1, IdSavings=1},
                new Person() {Id = 2, FirstName = "Ewa", LastName = "Farna", Age = 54, IdIncome = 2, IdSpending = 2, IdSavings=2},
                new Person() {Id = 3, FirstName = "Stanis³aw", LastName = "Kamiñski", Age = 70, IdIncome = 3, IdSpending = 3, IdSavings = 3},
                new Person() {Id = 4, FirstName = "Janina", LastName = "Kowalskia", Age = 20, IdIncome = 4, IdSpending = 4, IdSavings = 4},
                new Person() {Id = 5, FirstName = "Jurek", LastName = "Nowak", Age = 45, IdIncome = 5, IdSpending = 5, IdSavings = 5}

            };

            incomes = new List<Income>()
            {
                new Income() {Id = 1, Date = DateTime.Now, Wyplata = 3500, DodatkowaPraca = 500, Renta = 0, Wynajem = 0},
                new Income() {Id = 2, Date = DateTime.UtcNow,  Wyplata = 10000, DodatkowaPraca = 5000, Renta = 0, Wynajem = 0},
                new Income() {Id = 3, Date = DateTime.Now, Wyplata = 0, DodatkowaPraca = 0, Renta = 2500, Wynajem = 0},
                new Income() {Id = 4, Date = DateTime.UtcNow, Wyplata = 6500, DodatkowaPraca = 600, Renta = 0, Wynajem = 0},
                new Income() {Id = 5, Date = DateTime.Now, Wyplata = 5500, DodatkowaPraca = 700, Renta = 0, Wynajem = 0}
            };

            spendings = new List<Spending>()
            {
                new Spending() {Id = 1, Rachunki = 1500, Lekarstwa = 0, Jedzenie = 800, Wakacje = 0, Kredyty = 500, Nieoczekiwane = 0, Date = DateTime.Now },
                new Spending() {Id = 2, Rachunki = 2000, Lekarstwa = 0, Jedzenie = 2000, Wakacje = 5000, Kredyty = 500, Nieoczekiwane = 500, Date = DateTime.Now },
                new Spending() {Id = 3, Rachunki = 600, Lekarstwa = 500, Jedzenie = 600, Wakacje = 0, Kredyty = 0, Nieoczekiwane = 500, Date = DateTime.Now },
                new Spending() {Id = 4, Rachunki = 800, Lekarstwa = 200, Jedzenie = 800, Wakacje = 2500, Kredyty = 700, Nieoczekiwane = 600, Date = DateTime.Now },
                new Spending() {Id = 5, Rachunki = 1000, Lekarstwa = 0, Jedzenie = 1000, Wakacje = 2000, Kredyty = 500, Nieoczekiwane = 0, Date = DateTime.Now },


            };

            savings = new List<Saving>()
            {
                new Saving() {Id = 1,  Inwestycje = 0, Lokaty = 0, Obligacje = 600, Kieszonkowe = 600, NaPrzysz³oœæ = 0, Date = DateTime.Now },
                new Saving() {Id = 2,  Inwestycje = 1000, Lokaty = 500, Obligacje = 500, Kieszonkowe = 2000, NaPrzysz³oœæ = 1000, Date = DateTime.Now },
                new Saving() {Id = 3,  Inwestycje = 0, Lokaty = 0, Obligacje = 0, Kieszonkowe = 0, NaPrzysz³oœæ = 300, Date = DateTime.Now },
                new Saving() {Id = 4,  Inwestycje = 500, Lokaty = 0, Obligacje = 500, Kieszonkowe = 500, NaPrzysz³oœæ = 0, Date = DateTime.Now },
                new Saving() {Id = 5,  Inwestycje = 200, Lokaty = 300, Obligacje = 300, Kieszonkowe = 500, NaPrzysz³oœæ = 400, Date = DateTime.Now },



            };

            //     var modele = new Tuple<Person, Income, Spending>(Persons, incomes, spendings);
            var models = new List<ModelComplex>();

            // Iteruj przez ka¿d¹ osobê, przypisz jej odpowiedni dochód i wydatek
            foreach (var person in persons)
            {
                var model = new ModelComplex
                {
                    Person = person,
                    Income = incomes.FirstOrDefault(i => i.Id == person.IdIncome),
                    Spending = spendings.FirstOrDefault(s => s.Id == person.IdSpending),
                    Saving = savings.FirstOrDefault(sa => sa.Id == person.IdSavings)

                };

                models.Add(model);
            }

            return View(models);
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
