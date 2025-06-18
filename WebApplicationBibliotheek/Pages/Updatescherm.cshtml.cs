using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Business;
using Domain_bib.Persistence;
using Org.BouncyCastle.Security;

namespace WebApplicationBibliotheek.Pages
{
    // Dit is het code-behind model voor de Updatescherm Razor Page.
    // Hierin wordt de logica afgehandeld voor het bijwerken van een bestaand boek via een formulier.
    public class UpdateschermModel : PageModel
    {
        // Private velden voor de eigenschappen van het boek en berichten.
        private string _titel, _bericht, _auteur, _uitgever, _isbn;
        private int _graad, _genreId, _taalId, boekenId;

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

        // Eigenschap voor het ISBN van het boek, gekoppeld aan het formulier.
        [BindProperty]
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
        public int TaalId
        {
            get { return _taalId; }
            set { _taalId = value; }
        }

        // Eigenschap voor het statusbericht (bijvoorbeeld na bijwerken van een boek).
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }

        // Eigenschap voor het ID van het boek dat bijgewerkt moet worden, gekoppeld aan het formulier.
        [BindProperty]
        public int BoekenId
        {
            get { return boekenId; }
            set { boekenId = value; }
        }

        // Deze methode wordt aangeroepen wanneer het formulier via POST wordt verzonden.
        public IActionResult OnPost()
        {
            // Controleer of het opgegeven boek-ID geldig is.
            if (BoekenId <= 0)
            {
                Bericht = "Ongeldig Boek ID opgegeven.";
                return Page();
            }

            // Maak een nieuwe instantie van de Controller aan om de businesslogica aan te spreken.
            var conn = new Domain_bib.Business.Controller();

            // Haal het bestaande boek op aan de hand van het opgegeven ID.
            var bestaandBoek = conn.GetBoekById(BoekenId); // Zorg dat deze methode bestaat

            // Controleer of het boek bestaat.
            if (bestaandBoek == null)
            {
                Bericht = "Boek niet gevonden.";
                return Page();
            }

            // Gebruik de bestaande waarde als het veld leeg is (voor strings) of 0 (voor int).
            string titel = string.IsNullOrWhiteSpace(Titel) ? bestaandBoek.Titel : Titel;
            string auteur = string.IsNullOrWhiteSpace(Auteur) ? bestaandBoek.Auteur : Auteur;
            string uitgever = string.IsNullOrWhiteSpace(Uitgever) ? bestaandBoek.Uitgever : Uitgever;
            string isbn = string.IsNullOrWhiteSpace(ISBN) ? bestaandBoek.Isbn : ISBN;
            int graad = Graad == 0 ? bestaandBoek.Graad : Graad;
            int genreId = GenreId == 0 ? bestaandBoek.GenreId : GenreId;
            // Controleer of bestaandBoek.Taal een int bevat, anders behoud TaalId
            int taalId = TaalId == 0 
                ? (int.TryParse(bestaandBoek.Taal, out var bestaandTaalId) ? bestaandTaalId : TaalId) 
                : TaalId;

            // Roep de UpdateBoek-methode aan om het boek bij te werken met de nieuwe of bestaande waarden.
            conn.UpdateBoek(BoekenId, titel, genreId, auteur, uitgever, taalId, graad, isbn);

            // Zet een succesbericht dat het boek is bijgewerkt.
            Bericht = "Boek succesvol bijgewerkt!";

            // Wis de ModelState zodat het formulier leeg wordt na bijwerken.
            ModelState.Clear();

            // Blijf op dezelfde pagina zodat de gebruiker het resultaat ziet.
            return Page();
        }
    }
}

