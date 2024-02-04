using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SimpleMVC.Models
{
    public class Osoba
    {
        [Key]
        public int Id { get; set; }
        public int IdDostepu { get; set; }
        public int IdMajatek { get; set; }
        public int IdPrzychodStaly { get; set; }
        public int IdPrzychodZmienny { get; set; }
        public int IdOszczednosciStale { get; set; }
        public int IdOszczednosciZmienne { get; set; }
        public int IdWydatekStaly { get; set; }
        public int IdWydatekZmienny { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public DateTime DataDodaniaOsoby { get; set; }

        [ForeignKey("IdDostepu")]
        public Dostep Dostep { get; set; }

        [ForeignKey("IdMajatek")]
        public Majatek Majatek { get; set; }    
    
        [ForeignKey("IdPrzychodStaly")]
        public PrzychodStaly PrzychodStaly { get; set; }
 
        [ForeignKey("IdPrzychodZmienny")]
        public PrzychodZmienny PrzychodZmienny { get; set; }

        [ForeignKey("IdOszczednosciStale")]
        public OszczednosciStale OszczednosciStale { get; set; }
     
        [ForeignKey("IdOszczednosciZmienne")]
        public OszczednosciZmienne OszczednosciZmienne { get; set; }
        [ForeignKey("IdWydatekStaly")]
        public WydatekStaly WydatekStaly { get; set; }
        [ForeignKey("IdWydatekZmienny")]
        public WydatekZmienny WydatekZienny { get; set; }

       
        
    }

    

    public class Dostep
    {
        [Key]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }
        public DateTime DataLogowania { get; set; }
    }

   

    public class Majatek
    {
        [Key]
        public int Id { get; set; }
        public int IdNieruchomosc { get; set; }
        public int IdRuchomosc { get; set; }
        public int IdKamienieMetale { get; set; }
        public int IdPapieryWartosciowe { get; set; }
        public int IdGotowka { get; set; }

        [ForeignKey("IdNieruchomosc")]
        public Nieruchomosc Nieruchomosc { get; set; }

        [ForeignKey("IdRuchomosc")]
        public Ruchomosc Ruchomosc { get; set; }
        
        [ForeignKey("IdKamienieMetale")]
        public KamienieMetale KamienieMetale { get; set; }
        
        [ForeignKey("IdPapieryWartosciowe")]
        public PapieryWartosciowe PapieryWartosciowe { get; set; }
        
        [ForeignKey("IdGotowka")]
        public Gotowka Gotowka { get; set; }
    }

    public class Nieruchomosc
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Powierzchnia { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }
    public class Ruchomosc
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }
    public class KamienieMetale
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }
    public class PapieryWartosciowe
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }

    public class Gotowka
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }


public class PrzychodStaly
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public string Aktualizacja { get; set; }
        public DateTime Data { get; set; }
    }
;

public class PrzychodZmienny
    {
        [Key]
        public int Id { get; set; }

        public string Nazwa { get; set; }

        public int Wartosc { get; set; }

        public DateTime Data { get; set; }
    }


public class OszczednosciStale
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public string Aktualizacja { get; set; }
        public DateTime Data { get; set; }
    }
    public class OszczednosciZmienne
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }

    public class WydatekStaly
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int Wartosc { get; set; }
        public string Aktualizacja { get; set; }
        public DateTime Data { get; set; }
    }
    public class WydatekZmienny
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public int IdDostepu { get; set; }
        public int IdKategoria { get; set; }
        public int Wartosc { get; set; }
        public DateTime Data { get; set; }
    }
    public class Kategorie
    {
        [Key]
        public int Id { get; set; }
        public int IdJedzenie { get; set; }
        public int IdUzywki { get; set; }
        public int IdRozrywka { get; set; }
        public int IdNieoczekiwane { get; set; }
        public int IdUbrania { get; set; }
        public string Nazwa { get; set; }

        [ForeignKey("IdJedzenie")]
        public Jedzenie Jedzenie { get; set; }

        [ForeignKey("IdUzywki")]
        public Uzywki Uzywki { get; set; }

        [ForeignKey("IdRozrywka")]
        public Rozrywka Rozrywka { get; set; }

        [ForeignKey("IdNieoczekiwane")]
        public Nieoczekiwane Nieoczekiwane { get; set; }

        [ForeignKey("IdUbrania")]
        public Ubrania Ubrania { get; set; }

    }
    public class Jedzenie
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
    public class Uzywki
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
    public class Rozrywka
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
    public class Nieoczekiwane
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }
    public class Ubrania
    {
        [Key]
        public int Id { get; set; }
        public string Nazwa { get; set; }
    }

}