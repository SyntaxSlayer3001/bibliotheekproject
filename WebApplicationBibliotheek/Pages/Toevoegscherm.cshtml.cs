using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplicationBibliotheek.Pages
{
    public class ToevoegschermModel : PageModel
    {
        private string _titel, _bericht, _auteur, _uitgever, _isbn;
        private int _graad, _genreId, _taalId;
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
        public int taalId
        {
            get { return _taalId; }
            set { _taalId = value; }
        }
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }
        public IActionResult OnPost()
        {
            // Hier komt de logica om de film toe te voegen
            // Bijvoorbeeld: FilmToevoegen(Titel, GenreId, Voorraad, Prijs);
            // Na het toevoegen van de film kan je een redirect doen of een bericht tonen
            // Redirect naar een andere pagina na het toevoegen van de film
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Domain_bib.Business.Controller conn = new Domain_bib.Business.Controller();

            conn.InsertBoek(Titel, GenreId, Auteur, Uitgever, taalId, Graad, ISBN);

            Bericht = "Boek is toegevoegd";

            ModelState.Clear(); // Reset de modelstate om de invoer te wissen

            return Page(); // Blijf op dezelfde pagina
        }
    }
}
