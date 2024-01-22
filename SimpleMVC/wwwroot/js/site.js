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
        przyciskAktywowany.innerText = opcja;
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




