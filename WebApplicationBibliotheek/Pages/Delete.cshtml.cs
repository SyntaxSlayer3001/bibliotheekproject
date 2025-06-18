using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Business;
using Domain_bib.Persistence;

namespace WebApplicationBibliotheek.Pages
{
    // Dit is het code-behind model voor de Delete Razor Page.
    // Hierin wordt de logica afgehandeld voor het verwijderen van een boek via een formulier.
    public class DeleteModel : PageModel
    {
        // Private velden voor het statusbericht en het ID van het te verwijderen boek.
        private string _bericht;
        private int _boekenId;

        // Eigenschap voor het ID van het boek dat verwijderd moet worden, gekoppeld aan het formulier via [BindProperty].
        [BindProperty]
        public int BoekenId
        {
            get { return _boekenId; }
            set { _boekenId = value; }
        }

        // Eigenschap voor het statusbericht (bijvoorbeeld na verwijderen van een boek), gekoppeld aan het formulier.
        [BindProperty]
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }

        // Deze methode wordt aangeroepen wanneer het formulier via POST wordt verzonden.
        public IActionResult OnPost()
        {
            // Controleer of het opgegeven boek-ID geldig is.
            if (BoekenId <= 0)
            {
                // Voeg een foutmelding toe aan het ModelState als het ID ongeldig is.
                ModelState.AddModelError(string.Empty, "Ongeldig Boek ID opgegeven.");
                return Page();
            }

            // Maak een nieuwe instantie van de Controller aan om de businesslogica aan te spreken.
            Domain_bib.Business.Controller con = new Domain_bib.Business.Controller();

            // Roep de DeleteBoek-methode aan om het boek met het opgegeven ID te verwijderen.
            con.DeleteBoek(BoekenId);

            // Zet een succesbericht dat het boek is verwijderd.
            Bericht = "Boek succesvol verwijderd.";

            // Blijf op dezelfde pagina zodat de gebruiker het resultaat ziet.
            return Page();
        }
    }
}
