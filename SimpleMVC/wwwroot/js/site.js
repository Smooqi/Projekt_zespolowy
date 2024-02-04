// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function blokujPrzyciski() {
    var mainButtons = document.querySelectorAll('.przycisk1, .przycisk2, .przycisk3');

    mainButtons.forEach(function (button) {
        button.disabled = true;
    });
}

function odblokujPrzyciski() {
    var mainButtons = document.querySelectorAll('.przycisk1, .przycisk2, .przycisk3');

    mainButtons.forEach(function (button) {
        button.disabled = false;
    });
}

function pokazDodatkowePrzyciski(idDodatkowePrzyciski, przyciskGlowny) {
    var dodatkowePrzyciski = document.getElementById(idDodatkowePrzyciski);
    var przycisk = document.getElementById(przyciskGlowny);

    if (dodatkowePrzyciski.style.display === "none") {
        dodatkowePrzyciski.style.display = "flex";
        przycisk.style.display = "none";
        blokujPrzyciski();
    } else {
        dodatkowePrzyciski.style.display = "none";
        przycisk.style.display = "block";
        odblokujPrzyciski();
    }
}

function wybierzOpcje(opcja) {
    var przyciskAktywowany;

    switch (opcja) {
        case '+ Dodaj wydatek 1':
        case '+ Dodaj wydatek 2':
            przyciskAktywowany = document.getElementById("przyciskWydatek");
            break;
        case '+ Dodaj przychod 1':
        case '+ Dodaj przychod 2':
            przyciskAktywowany = document.getElementById("przyciskPrzychod");
            break;
        case '+ Dodaj oszczednosc 1':
        case '+ Dodaj oszczednosc 2':
            przyciskAktywowany = document.getElementById("przyciskOszczednosc");
            break;
        default:
            przyciskAktywowany = null;
            break;
    }

    if (przyciskAktywowany) {
        przyciskAktywowany.disabled = true;
        odblokujPrzyciski();
    }
}

function zobaczFormularzZwykly() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski1 = document.getElementById('dodatkowePrzyciski1');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski1.style.display = 'none';

    // Pokaż formularz zwykłego wydatku
    var formularz = document.getElementById('formularzZwyklyWydatek');
    formularz.style.display = 'block';
}

function zapiszZwykly() {
    var nazwa = document.getElementById('nazwaZwyklegoWydatku').value;
    var kategoria = document.getElementById('kategoriaZwyklegoWydatku').value;
    var ile = document.getElementById('ileZwyklegoWydatku').value;
    var data = document.getElementById('dataZwyklegoWydatku').value;

    // Tutaj możesz dodać kod obsługujący zapis wydatku
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzZwyklyWydatek');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}

function zobaczFormularzStaly() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski1 = document.getElementById('dodatkowePrzyciski1');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski1.style.display = 'none';

    // Pokaż formularz zwykłego wydatku
    var formularz = document.getElementById('formularzStalyWydatek');
    formularz.style.display = 'block';
}

function zapiszStaly() {
    var nazwa = document.getElementById('nazwaStalegoWydatku').value;
    var ile = document.getElementById('ileStalegoWydatku').value;
    var kiedy = document.getElementById('kiedyStalegoWydatku').value;
    var data = document.getElementById('dataStalegoWydatku').value;

    // Tutaj możesz dodać kod obsługujący zapis wydatku
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzStalyWydatek');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}

function zobaczFormularzZwyklyPrzychod() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski2 = document.getElementById('dodatkowePrzyciski2');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski2.style.display = 'none';

    // Pokaż formularz zwykłego przychodu
    var formularz = document.getElementById('formularzZwyklyPrzychod');
    formularz.style.display = 'block';
}

function zapiszZwyklyPrzychod() {
    var nazwa = document.getElementById('nazwaZwyklegoPrzychodu').value;
    var ile = document.getElementById('ileZwyklegoPrzychodu').value;
    var data = document.getElementById('dataZwyklegoPrzychodu').value;

    // Tutaj możesz dodać kod obsługujący zapis przychodu
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzZwyklyPrzychod');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}

function zobaczFormularzStalyPrzychod() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski2 = document.getElementById('dodatkowePrzyciski2');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski2.style.display = 'none';

    // Pokaż formularz stałego przychodu
    var formularz = document.getElementById('formularzStalyPrzychod');
    formularz.style.display = 'block';
}

function zapiszStalyPrzychod() {
    var nazwa = document.getElementById('nazwaStalegoPrzychodu').value;
    var ile = document.getElementById('ileStalegoPrzychodu').value;
    var kiedy = document.getElementById('kiedyStalegoPrzychodu').value;
    var data = document.getElementById('dataStalegoPrzychodu').value;

    // Tutaj możesz dodać kod obsługujący zapis stałego przychodu
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzStalyPrzychod');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}
function zobaczFormularzZwyklaOszczednosc() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski3 = document.getElementById('dodatkowePrzyciski3');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski3.style.display = 'none';

    // Pokaż formularz zwykłej oszczędności
    var formularz = document.getElementById('formularzZwyklaOszczednosc');
    formularz.style.display = 'block';
}

function zapiszZwyklaOszczednosc() {
    var nazwa = document.getElementById('nazwaZwyklejOszczednosci').value;
    var ile = document.getElementById('ileZwyklejOszczednosci').value;
    var data = document.getElementById('dataZwyklejOszczednosci').value;

    // Tutaj możesz dodać kod obsługujący zapis oszczędności
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzZwyklaOszczednosc');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}

function zobaczFormularzStalaOszczednosc() {
    // Ukryj przyciski dodatkowe
    var dodatkowePrzyciski3 = document.getElementById('dodatkowePrzyciski3');
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'none';
    przyciskPrzychod.style.display = 'none';
    przyciskOszczednosc.style.display = 'none';
    dodatkowePrzyciski3.style.display = 'none';

    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzStalaOszczednosc');
    formularz.style.display = 'block';
}

function zapiszStalaOszczednosc() {
    var nazwa = document.getElementById('nazwaStalejOszczednosci').value;
    var ile = document.getElementById('ileStalejOszczednosci').value;
    var kiedy = document.getElementById('kiedyStalejOszczednosci').value;
    var data = document.getElementById('dataStalejOszczednosci').value;

    // Tutaj możesz dodać kod obsługujący zapis stałej oszczędności
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzStalaOszczednosc');
    formularz.style.display = 'none';

    // Po zapisie przywróć widoczność przycisków dodatkowych
    var przyciskWydatek = document.getElementById('przyciskWydatek');
    var przyciskPrzychod = document.getElementById('przyciskPrzychod');
    var przyciskOszczednosc = document.getElementById('przyciskOszczednosc');

    przyciskWydatek.style.display = 'block';
    przyciskPrzychod.style.display = 'block';
    przyciskOszczednosc.style.display = 'block';

    odblokujPrzyciski();
}

function editSpending(category) {
    // Implementacja logiki edycji dla wydatku o danej kategorii
    // Możesz użyć modala lub formularza do wprowadzania nowych danych
    alert('Edytuj wydatek: ' + category);
}

function deleteSpending(category) {
    // Confirm deletion with the user
    var confirmDelete = confirm('Czy na pewno chcesz usunąć wydatek: ' + category + '?');

    if (confirmDelete) {
        // Remove the corresponding expense from the list
        var listItem = document.querySelector('li[data-category="' + category + '"]');
        if (listItem) {
            listItem.remove();
        } else {
            alert('Nie można odnaleźć wydatku do usunięcia.');
        }
    }
}

function editIncoming(category) {
    // Implementacja logiki edycji dla wydatku o danej kategorii
    // Możesz użyć modala lub formularza do wprowadzania nowych danych
    alert('Edytuj przychod: ' + category);
}

function deleteIncoming(category) {
    // Confirm deletion with the user
    var confirmDelete = confirm('Czy na pewno chcesz usunąć przychod: ' + category + '?');

    if (confirmDelete) {
        // Remove the corresponding expense from the list
        var listItem = document.querySelector('li[data-category="' + category + '"]');
        if (listItem) {
            listItem.remove();
        } else {
            alert('Nie można odnaleźć przychodu do usunięcia.');
        }
    }
}

function editSavings(category) {
    // Implementacja logiki edycji dla wydatku o danej kategorii
    // Możesz użyć modala lub formularza do wprowadzania nowych danych
    alert('Edytuj oszczednosc: ' + category);
}

function deleteSavings(category) {
    // Confirm deletion with the user
    var confirmDelete = confirm('Czy na pewno chcesz usunąć oszczednosc: ' + category + '?');

    if (confirmDelete) {
        // Remove the corresponding expense from the list
        var listItem = document.querySelector('li[data-category="' + category + '"]');
        if (listItem) {
            listItem.remove();
        } else {
            alert('Nie można odnaleźć oszczednosc do usunięcia.');
        }
    }
}

function editFortune(category) {
    // Implementacja logiki edycji dla wydatku o danej kategorii
    // Możesz użyć modala lub formularza do wprowadzania nowych danych
    alert('Edytuj majatek: ' + category);
}

function deleteFortune(category) {
    // Confirm deletion with the user
    var confirmDelete = confirm('Czy na pewno chcesz usunąć majatek: ' + category + '?');

    if (confirmDelete) {
        // Remove the corresponding expense from the list
        var listItem = document.querySelector('li[data-category="' + category + '"]');
        if (listItem) {
            listItem.remove();
        } else {
            alert('Nie można odnaleźć majatek do usunięcia.');
        }
    }
}



function zobaczFormularzMajatekR() {

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'none';
    przyciskMajatekN.style.display = 'none';
    przyciskMajatekMK.style.display = 'none';
    przyciskMajatekPW.style.display = 'none';
    przyciskMajatekG.style.display = 'none';



    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzMajatekR');
    formularz.style.display = 'block';
}

function zapiszMajatekR() {
    var nazwa = document.getElementById('nazwaMajatkuR').value;
    var wartosc = document.getElementById('wartoscMajatekR').value;
 

    // Tutaj możesz dodać kod obsługujący zapis 
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzMajatekR');
    formularz.style.display = 'none';

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'block';
    przyciskMajatekN.style.display = 'block';
    przyciskMajatekMK.style.display = 'block';
    przyciskMajatekPW.style.display = 'block';
    przyciskMajatekG.style.display = 'block';


   
}

function zobaczFormularzMajatekN() {

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'none';
    przyciskMajatekN.style.display = 'none';
    przyciskMajatekMK.style.display = 'none';
    przyciskMajatekPW.style.display = 'none';
    przyciskMajatekG.style.display = 'none';



    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzMajatekN');
    formularz.style.display = 'block';
}

function zapiszMajatekN() {
    var nazwa = document.getElementById('nazwaMajatkuN').value;
    var wartosc = document.getElementById('wartoscMajatekN').value;
    var powierzchnia = document.getElementById('powierzchniaMajatekN').value;


    // Tutaj możesz dodać kod obsługujący zapis 
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzMajatekN');
    formularz.style.display = 'none';

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'block';
    przyciskMajatekN.style.display = 'block';
    przyciskMajatekMK.style.display = 'block';
    przyciskMajatekPW.style.display = 'block';
    przyciskMajatekG.style.display = 'block';



}

function zobaczFormularzMajatekMK() {

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'none';
    przyciskMajatekN.style.display = 'none';
    przyciskMajatekMK.style.display = 'none';
    przyciskMajatekPW.style.display = 'none';
    przyciskMajatekG.style.display = 'none';



    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzMajatekMK');
    formularz.style.display = 'block';
}

function zapiszMajatekMK() {
    var nazwa = document.getElementById('nazwaMajatkuMK').value;
    var wartosc = document.getElementById('wartoscMajatekMK').value;
   


    // Tutaj możesz dodać kod obsługujący zapis 
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzMajatekMK');
    formularz.style.display = 'none';

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'block';
    przyciskMajatekN.style.display = 'block';
    przyciskMajatekMK.style.display = 'block';
    przyciskMajatekPW.style.display = 'block';
    przyciskMajatekG.style.display = 'block';



}

function zobaczFormularzMajatekPW() {

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'none';
    przyciskMajatekN.style.display = 'none';
    przyciskMajatekMK.style.display = 'none';
    przyciskMajatekPW.style.display = 'none';
    przyciskMajatekG.style.display = 'none';



    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzMajatekPW');
    formularz.style.display = 'block';
}

function zapiszMajatekPW() {
    var nazwa = document.getElementById('nazwaMajatkuPW').value;
    var wartosc = document.getElementById('wartoscMajatekPW').value;
    


    // Tutaj możesz dodać kod obsługujący zapis 
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzMajatekPW');
    formularz.style.display = 'none';

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'block';
    przyciskMajatekN.style.display = 'block';
    przyciskMajatekMK.style.display = 'block';
    przyciskMajatekPW.style.display = 'block';
    przyciskMajatekG.style.display = 'block';



}

function zobaczFormularzMajatekG() {

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'none';
    przyciskMajatekN.style.display = 'none';
    przyciskMajatekMK.style.display = 'none';
    przyciskMajatekPW.style.display = 'none';
    przyciskMajatekG.style.display = 'none';



    // Pokaż formularz stałej oszczędności
    var formularz = document.getElementById('formularzMajatekG');
    formularz.style.display = 'block';
}

function zapiszMajatekG() {
    var nazwa = document.getElementById('nazwaMajatkuG').value;
    var wartosc = document.getElementById('wartoscMajatekG').value;



    // Tutaj możesz dodać kod obsługujący zapis 
    // ...

    // Po zapisie ukryj formularz
    var formularz = document.getElementById('formularzMajatekG');
    formularz.style.display = 'none';

    var przyciskMajatekR = document.getElementById('przyciskMajatekR');
    var przyciskMajatekN = document.getElementById('przyciskMajatekN');
    var przyciskMajatekMK = document.getElementById('przyciskMajatekMK');
    var przyciskMajatekPW = document.getElementById('przyciskMajatekPW');
    var przyciskMajatekG = document.getElementById('przyciskMajatekG');

    przyciskMajatekR.style.display = 'block';
    przyciskMajatekN.style.display = 'block';
    przyciskMajatekMK.style.display = 'block';
    przyciskMajatekPW.style.display = 'block';
    przyciskMajatekG.style.display = 'block';



}

const slider = document.querySelector('.slider');
const slides = document.querySelectorAll('.slide');
const prevBtn = document.querySelector('.prev');
const nextBtn = document.querySelector('.next');
let currentIndex = 0;

nextBtn.addEventListener('click', () => {
    if (currentIndex < slides.length - 1) {
        currentIndex++;
    } else {
        currentIndex = 0;
    }
    updateSlider();
});

prevBtn.addEventListener('click', () => {
    if (currentIndex > 0) {
        currentIndex--;
    } else {
        currentIndex = slides.length - 1;
    }
    updateSlider();
});

function updateSlider() {
    const translateValue = -currentIndex * 100 + '%';
    slider.style.transform = 'translateX(' + translateValue + ')';
}




//pie
var ctxP = document.getElementById("pieChart").getContext('2d');
var myPieChart = new Chart(ctxP, {
    type: 'pie',
    data: {
        labels: ["Red", "Green", "Yellow", "Grey", "Dark Grey"],
        datasets: [{
            data: [300, 50, 100, 40, 120],
            backgroundColor: ["#F7464A", "#46BFBD", "#FDB45C", "#949FB1", "#4D5360"],
            hoverBackgroundColor: ["#FF5A5E", "#5AD3D1", "#FFC870", "#A8B3C5", "#616774"]
        }]
    },
    options: {
        responsive: true
    }
})

//bar
var ctxB = document.getElementById("barChart").getContext('2d');
var myBarChart = new Chart(ctxB, {
    type: 'bar',
    data: {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255,99,132,1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    }
})
