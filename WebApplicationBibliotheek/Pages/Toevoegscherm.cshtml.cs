using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationBibliotheek.Pages
{
    // Deze klasse is het code-behind model voor de Toevoegscherm Razor Page.
    // Hierin wordt de logica afgehandeld voor het toevoegen van een nieuw boek via een formulier.
    public class ToevoegschermModel : PageModel
    {
        // Private velden voor de eigenschappen van het boek en berichten.
        private string _titel, _bericht, _auteur, _uitgever, _isbn;
        private int _graad, _genreId, _taalId;

        // Eigenschap voor de titel van het boek, gekoppeld aan het formulier via [BindProperty].
        [BindProperty]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        // Eigenschap voor de auteur van het boek, gekoppeld aan het formulier.
        [BindProperty]
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        // Eigenschap voor de uitgever van het boek, gekoppeld aan het formulier.
        [BindProperty]
        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }

        // Eigenschap voor het ISBN van het boek (niet gebonden aan het formulier).
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        // Eigenschap voor de graad (doelgroep/niveau) van het boek, gekoppeld aan het formulier.
        [BindProperty]
        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }

        // Eigenschap voor het genre van het boek, gekoppeld aan het formulier.
        [BindProperty]
        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        // Eigenschap voor de taal van het boek, gekoppeld aan het formulier.
        [BindProperty]
        public int taalId
        {
            get { return _taalId; }
            set { _taalId = value; }
        }

        // Eigenschap voor het statusbericht (bijvoorbeeld na toevoegen van een boek).
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }

        // Deze methode wordt aangeroepen wanneer het formulier via POST wordt verzonden.
        public IActionResult OnPost()
        {
            // Controleer of het model geldig is (alle validaties geslaagd).
            if (!ModelState.IsValid)
            {
                // Als er validatiefouten zijn, blijf op dezelfde pagina en toon fouten.
                return Page();
            }

            // Maak een nieuwe instantie van de Controller aan om de businesslogica aan te spreken.
            Domain_bib.Business.Controller conn = new Domain_bib.Business.Controller();

            // Voeg het boek toe via de InsertBoek-methode van de Controller.
            conn.InsertBoek(Titel, GenreId, Auteur, Uitgever, taalId, Graad, ISBN);

            // Zet een succesbericht dat het boek is toegevoegd.
            Bericht = "Boek is toegevoegd";

            // Wis de ModelState zodat het formulier leeg wordt na toevoegen.
            ModelState.Clear();

            // Blijf op dezelfde pagina zodat de gebruiker het resultaat ziet.
            return Page();
        }
    }
}
