using Microsoft.AspNetCore.Mvc;
using SimpleMVC.Models;

namespace SimpleMVC.Controllers
{
    public class About : Controller
    {
        
        
        // GET: SimpleController
        private List<Person>? persons;
        private List<Income>? incomes;
        private List<Spending>? spendings;
        private List<Saving> savings;
        private List<Fortune> fortune;

        //   public List<Person> Persons { get; set; } = new List<Person>();


        public ActionResult Index()
        {
            // SimpleExemple exemples = new SimpleExemple("trangle", 3.4f, 4.6f);
            persons = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Jan", LastName = "Kowalski", Age = 35, IdIncome = 1, IdSpending = 1, IdSavings=1},
                new Person() {Id = 2, FirstName = "Ewa", LastName = "Farna", Age = 54, IdIncome = 2, IdSpending = 2, IdSavings=2},
                new Person() {Id = 3, FirstName = "Stanisław", LastName = "Kamiński", Age = 70, IdIncome = 3, IdSpending = 3, IdSavings = 3},
                new Person() {Id = 4, FirstName = "Janina", LastName = "Kowalskia", Age = 20, IdIncome = 4, IdSpending = 4, IdSavings = 4},
                new Person() {Id = 5, FirstName = "Jurek", LastName = "Nowak", Age = 45, IdIncome = 5, IdSpending = 5, IdSavings = 5}

            };

            incomes = new List<Income>()
            {
                new Income() {Id = 1, Date = DateTime.Now, Wypłata = 3500, DodatkowaPraca = 500, Renta = 0},
                new Income() {Id = 2, Date = DateTime.UtcNow,  Wypłata = 10000, DodatkowaPraca = 5000, Renta = 0},
                new Income() {Id = 3, Date = DateTime.Now, Wypłata = 0, DodatkowaPraca = 0, Renta = 2500},
                new Income() {Id = 4, Date = DateTime.UtcNow, Wypłata = 6500, DodatkowaPraca = 600, Renta = 0},
                new Income() {Id = 5, Date = DateTime.Now, Wypłata = 5500, DodatkowaPraca = 700, Renta = 0}
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
                new Saving() {Id = 1,  Inwestycje = 0, Lokaty = 0, Obligacje = 600, Kieszonkowe = 600, NaPrzyszłość = 0, Date = DateTime.Now },
                new Saving() {Id = 2,  Inwestycje = 1000, Lokaty = 500, Obligacje = 500, Kieszonkowe = 2000, NaPrzyszłość = 1000, Date = DateTime.Now },
                new Saving() {Id = 3,  Inwestycje = 0, Lokaty = 0, Obligacje = 0, Kieszonkowe = 0, NaPrzyszłość = 300, Date = DateTime.Now },
                new Saving() {Id = 4,  Inwestycje = 500, Lokaty = 0, Obligacje = 500, Kieszonkowe = 500, NaPrzyszłość = 0, Date = DateTime.Now },
                new Saving() {Id = 5,  Inwestycje = 200, Lokaty = 300, Obligacje = 300, Kieszonkowe = 500, NaPrzyszłość = 400, Date = DateTime.Now },



            };

            fortune = new List<Fortune>()
            {
                new Fortune() {Id = 1,  Ruchomosc= 10000, Nieruchomosci = 500000, MetaleIKamienieSzlachetne = 200, PapieryWartosciowe = 0, Gotowka = 40000, Date = DateTime.Now },
                new Fortune() {Id = 2,  Ruchomosc= 20000, Nieruchomosci = 400000, MetaleIKamienieSzlachetne = 800, PapieryWartosciowe = 1000, Gotowka = 30000, Date = DateTime.Now },
                new Fortune() {Id = 3,  Ruchomosc= 30000, Nieruchomosci = 300000, MetaleIKamienieSzlachetne = 0, PapieryWartosciowe = 0, Gotowka = 15000, Date = DateTime.Now },
                new Fortune() {Id = 4,  Ruchomosc= 10000, Nieruchomosci = 300000, MetaleIKamienieSzlachetne = 300, PapieryWartosciowe = 0, Gotowka = 100000, Date = DateTime.Now },
                new Fortune() {Id = 5,  Ruchomosc= 20000, Nieruchomosci = 600000, MetaleIKamienieSzlachetne = 0, PapieryWartosciowe = 0, Gotowka = 20000, Date = DateTime.Now },



            };

            //     var modele = new Tuple<Person, Income, Spending>(Persons, incomes, spendings);
            var models = new List<ModelComplex>();

            // Iteruj przez każdą osobę, przypisz jej odpowiedni dochód i wydatek
            foreach (var person in persons)
            {
                var model = new ModelComplex
                {
                    Person = person,
                    Income = incomes.FirstOrDefault(i => i.Id == person.IdIncome),
                    Spending = spendings.FirstOrDefault(s => s.Id == person.IdSpending),
                    Saving = savings.FirstOrDefault(sa => sa.Id == person.IdSavings),
                    Fortune = fortune.FirstOrDefault(sa => sa.Id == person.IdSavings)

                };

                models.Add(model);
            }

            return View(models);
        }

        // GET:SimpleController/Details/5
        [HttpPost]
        public ActionResult Details(int id)
        {
            if (id == null)
                return BadRequest("Nie ma takiej osoby w bazie");

            // var oneperson = persons.
            Person persons = new Person();
            if ((ModelState.IsValid) && (persons.Id == id))
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

