using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SimpleMVC.Models
{

    #region Person
    public class Person
    {
        private readonly int id;
        public int Id { get; set; }

        private string? firstname;
        public string FirstName { get; set; } = string.Empty;

        private string? lastname;
        public string LastName { get; set; } = string.Empty;

        private int? age;

        public int? Age { get; set; }

        private int idincome;

        public int? IdIncome { get; set; }

        private int idspending;

        public int? IdSpending { get; set; }

        private int idsavings;

        public int? IdSavings { get; set; }

        private int idfortune;

        public int? IdFortune { get; set; }
    }
    #endregion

    #region Income
    public class Income
    {
        private int id;
        public int Id { get; set; }

        private float wypłata;
        public float Wypłata { get; set; }

        private float sdodatkowapraca;
        public float DodatkowaPraca { get; set; }

        private float renta;
        public float Renta { get; set;}
        
        private DateTime? date;
        public DateTime? Date { get; set; } 

    }
    #endregion

    #region Spending
    public class Spending
    {
        private int id;
        public int Id { get; set; }

        private float rachunki;
        public float Rachunki { get; set; }

        private float jedzenie;
        public float Jedzenie { get; set; }

        private float lekarstwa;
        public float Lekarstwa { get; set; }

        private float kredyty;
        public float Kredyty { get; set; }

        private float wakacje;
        public float Wakacje { get; set; }

        private float nieoczekiwane;
        public float Nieoczekiwane { get; set; }

        private DateTime date;
        public DateTime Date { get; set; }

    }

    #endregion

    #region Saving
    public class Saving
    {
        private int id;
        public int Id { get; set; }

        private float inwestycje;
        public float Inwestycje { get; set; }

        private float lokaty;
        public float Lokaty { get; set; }

        private float obligacje;
        public float Obligacje { get; set; }

        private float kieszonkowe;
        public float Kieszonkowe { get; set; }

        private float naprzyszłość;
        public float NaPrzyszłość { get; set; }



        private DateTime date;
        public DateTime Date { get; set; }

    }

    #endregion

    #region Fortune
    public class Fortune
    {
        private int id;
        public int Id { get; set; }

        private float ruchomosci;
        public float Ruchomosc { get; set; }

        private float nieruchomosci;
        public float Nieruchomosci { get; set; }

        private float Metaleikamienie;
        public float MetaleIKamienieSzlachetne { get; set; }

        private float Papierywartosciowe;
        public float PapieryWartosciowe { get; set; }

        private float gotowka;
        public float Gotowka { get; set; }



        private DateTime date;
        public DateTime Date { get; set; }

    }

    #endregion

    public class ModelComplex
    {
        public Person Person { get; set; }

        public Income Income { get; set; }

        public Spending Spending { get; set; }

        public Saving Saving { get; set; }

        public Fortune Fortune { get; set; }


    }

    #region SimpleExemple
    public class SimpleExemple
    {
        private string shape;

        public string? Shape { get; set; }

        private float girth;

        public float? Girth { get; set; }
        
        private float area;

        public float? Area { get; set; }

       public SimpleExemple(string shape, float girth, float area)
        {
            this.shape = shape;
            this.girth = girth;
            this.area = area;
        }

        public SimpleExemple()
        {
            this.shape = String.Empty;
            this.girth = 0;
            this.area = 0;
        }
    }
    #endregion 
}
