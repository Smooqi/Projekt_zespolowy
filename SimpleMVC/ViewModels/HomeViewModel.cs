using System.Collections.Generic;
using SimpleMVC.Models;

namespace SimpleMVC.ViewModels
{
    
    public class HomeViewModelOne
    {
        public Dostep Zalogowany { get; set; }
        public String Imie {  get; set; }
        public PrzychodStaly PrzychodStaly {  get; set; }
        public PrzychodZmienny PrzychodZmienny { get; set; }
        public WydatekStaly WydatekStaly { get; set; }
        public WydatekZmienny WydatekZmienny { get; set; }
        public OszczednosciStale OszczednosciStale {  get; set; }
        public OszczednosciZmienne OszczednosciZmienne {  get; set; }
        public Majatek Majatek { get; set; }
        public Osoba Osoba {  get; set; }
    }

   
    public class HomeViewModel
    {
        public Dostep ZalogowanyDostep { get; set; }
        public string ImieUzytkownika { get; set; }
        public List<PrzychodStaly> PrzychodyStale { get; set; }
        public List<PrzychodZmienny> PrzychodyZmienne { get; set; }
        public List<WydatekStaly> WydatkiStale { get; set; }
        public List<WydatekZmienny> WydatkiZmienne { get; set; }
        public List<OszczednosciStale> OszczednosciStale { get; set; }
        public List<OszczednosciZmienne> OszczednosciZmienne { get; set; }
        public Osoba Osoba { get; set; }
    }
 }
