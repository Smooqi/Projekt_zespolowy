using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            // SimpleExemple exemples = new SimpleExemple("trangle", 3.4f, 4.6f);
            persons = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 25, IdIncome = 1, IdSpending = 1},
                new Person() {Id = 2, FirstName = "Ewa", LastName = "Farna", Age = 54, IdIncome = 2, IdSpending = 2},
                new Person() {Id = 3, FirstName = "Stanis³aw", LastName = "Kamiñski", Age = 45, IdIncome = 3, IdSpending = 3},
                new Person() {Id = 4, FirstName = "Janina", LastName = "Kowalskia", Age = 17, IdIncome = 4, IdSpending = 4},
                new Person() {Id = 5, FirstName = "Jurek", LastName = "Nowak", Age = 12, IdIncome = 5, IdSpending = 5}

            };

            incomes = new List<Income>()
            {
                new Income() {Id = 1, Date = DateTime.Now, Rental = 0, Salary = 4400, SideJob = 500},
                new Income() {Id = 2, Date = DateTime.UtcNow, Rental = 0, Salary = 400, SideJob = 0},
                new Income() {Id = 3, Date = DateTime.Now, Rental = 2000, Salary = 14400, SideJob = 1500},
                new Income() {Id = 4, Date = DateTime.UtcNow, Rental = 1000, Salary = 2400, SideJob = 500},
                new Income() {Id = 5, Date = DateTime.Now, Rental = 0, Salary = 3400, SideJob = 0}
            };

            spendings = new List<Spending>()
            {
                new Spending() {Id = 1, Bills = 2000, Drugs = 0, Food = 800, Holidays = 3000, Loans = 500, Unexpected = 2000, Date = DateTime.Now },
                new Spending() {Id = 2, Bills = 5000, Drugs = 500, Food = 1000, Holidays = 3000, Loans = 500, Unexpected = 500, Date = DateTime.Now },
                new Spending() {Id = 3, Bills = 13000, Drugs = 0, Food = 1500, Holidays = 13000, Loans = 500, Unexpected = 1000, Date = DateTime.Now },
                new Spending() {Id = 4, Bills = 0, Drugs = 200, Food = 500, Holidays = 0, Loans = 500, Unexpected = 0, Date = DateTime.Now },
                new Spending() {Id = 5, Bills = 0, Drugs = 0, Food = 0, Holidays = 0, Loans = 500, Unexpected = 0, Date = DateTime.Now },


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
                    Spending = spendings.FirstOrDefault(s => s.Id == person.IdSpending)
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
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
