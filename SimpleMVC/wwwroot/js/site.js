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



