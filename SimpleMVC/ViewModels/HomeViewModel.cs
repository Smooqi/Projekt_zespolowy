using System.Collections.Generic;
using SimpleMVC.Models;

namespace SimpleMVC.ViewModels
{
    

   
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
