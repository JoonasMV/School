'use strict';

/*
	Javascript-tiedosto AJAX-tehtäviä varten.
	Jos etsitään TV-sarjoja haulla "girls", niin TV Maze APIsta suoritettava hakuosoite on:
	https://api.tvmaze.com/search/shows?q=girls
	Testaa haun toimintaa omassa selaimessa.
	Kun koodi toimii, niin poista turhat open höpinät.
*/

// hakuosoitteen vakio-osa.
const apiurl = "https://api.tvmaze.com/search/shows?q=";

// lopullinen hakukysely, joka lähetetään nettiin.
let apiKysely;

// Etsitään HTML-sivulta tarvittavat komponentit id:n avulla.
const hakunappi = document.getElementById("hakunappi");
// TODO: etsi hakukenttä eli syöttökenttä johon käyttäjä kirjoittaa hakusanan.
// TODO: etsi html-sivulta main-tagi eli minkä sisään hakutulokset laitetaan.


// lisätään napille tapahtumankäsittelijä
hakunappi.addEventListener('click', teeKysely);

// Funktio muodostaa hakukyselyn.
// Lopuksi funktio kutsuu teeHaku() funktiota.
function teeKysely() {
    // TODO: haetaan html-sivulta käyttäjän antama hakuteksti (muista .value)
    // TODO: muuta alla oleva kovakoodaus hakusanasta.
    let hakusana = "fbi";         // HUOM: tässä on 'kovakoodattu' hakusana!!!

    // muodostetaan ja tulostetaan konsoliin lopullinen hakukysely
    apiKysely = apiurl + hakusana;
    console.log("Lähetettävä kysely: " + apiKysely);

    // kutsutaan fetch-jutut hoitavaa funktiota
    teeHaku(apiKysely);        // parametrina hakulause
}


// Idea: tämä fetch-osa säilyy yleensä samana.
// Funktio saa parametrina hakulauseen.
function teeHaku(apiKysely)  {

    // suoritetaan hakukysely, fetch hoitaa mahdolliset tietoliikenneongelmat.
    fetch(apiKysely).then(function(response) {
        return response.json();
    }).then(function(json) {
        naytaVastaus(json);				// siirrytään varsinaisen datan käsittelyyn.
    }).catch(function(error){           // Jos tapahtuu virhe,
        console.log(error);             // kirjoitetaan virhe konsoliin.
    });
}


// Funktio hoitaa kyselystä saadun json-datan käsittelyn.
// Funktio saa parametrina json-muodossa olevan datan.
function naytaVastaus(jsonData) {
    // AJAX-tehtävän vaihe 1 on suoritettu, jos alla oleva koodi
    // tulostaa konsoliin noin 10 sarjan tiedot (Array, jonka koko on 10).
    // Muuta kuitenkin koodia että hakee käyttäjän antamalla hakusanalla.
    console.log("json sellaisenaan");
    console.log(jsonData);
    console.log("Sellainen se json oli.");

    /*
        Aha, json-dataoliot ovat siis taulukossa.
        Yksi dataolio sisältää yhden sarjan tiedot.
        Ope ei osaa käsitellä kuin eka sarjan tietoja.
        Mistä mikin data löytyy: katso TV-Mazen API-kuvauksesta.
    */

    // Ope ei osaa kuin tulostaa ujosti konsoliin.
    // Ota tämäkin pois, kun oma koodisi toimii.

    // Tulostetaan konsoliin muutama tieto eka sarjasta jsonData[0].
    console.log("Eka sarjan nimi: " + jsonData[0].show.name);
    console.log("Eka sarjan kuvan osoite: " + jsonData[0].show.image.medium);
    console.log("Eka sarjan virallinen kotisivu: " + jsonData[0].show.officialSite);

    // TODO: kerää tarvittava data ja tulosta se web-sivulle.
    // Valmistellaan html-sivulle tuleva koodi.

    let htmlKoodi = ``;

}



