using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Business;
using Domain_bib.Persistence;
using Org.BouncyCastle.Security;

namespace WebApplicationBibliotheek.Pages
{
    public class UpdateschermModel : PageModel
    {
        private string _titel, _bericht, _auteur, _uitgever, _isbn;
        private int _graad, _genreId, _taalId, boekenId;

        [BindProperty]
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        [BindProperty]
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        [BindProperty]
        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }
        [BindProperty]
        public string ISBN
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        [BindProperty]
        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }
        [BindProperty]
        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }
        [BindProperty]
        public int TaalId
        {
            get { return _taalId; }
            set { _taalId = value; }
        }
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }
        [BindProperty]
        public int BoekenId
        {
            get { return boekenId; }
            set { boekenId = value; }
        }
        public IActionResult OnPost()
        {
            if (BoekenId <= 0)
            {
                Bericht = "Ongeldig Boek ID opgegeven.";
                return Page();
            }

            var conn = new Domain_bib.Business.Controller();
            var bestaandBoek = conn.GetBoekById(BoekenId); // Zorg dat deze methode bestaat

            if (bestaandBoek == null)
            {
                Bericht = "Boek niet gevonden.";
                return Page();
            }

            // Gebruik bestaande waarde als het veld leeg is (voor strings) of 0 (voor int)
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

            conn.UpdateBoek(BoekenId, titel, genreId, auteur, uitgever, taalId, graad, isbn);
            Bericht = "Boek succesvol bijgewerkt!";

            ModelState.Clear();

            return Page();
        }
    }
}

