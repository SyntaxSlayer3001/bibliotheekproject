using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Business;
using Domain_bib.Persistence;

namespace WebApplicationBibliotheek.Pages
{
    public class DeleteModel : PageModel
    {
        private string _bericht;
        private int _boekenId;
        [BindProperty]
        public int BoekenId
        {
            get { return _boekenId; }
            set { _boekenId = value; }
        }
        [BindProperty]
        public string Bericht
        {
            get { return _bericht; }
            set { _bericht = value; }
        }
        public IActionResult OnPost()
        {
            if (BoekenId <= 0)
            {
                ModelState.AddModelError(string.Empty, "Ongeldig Boek ID opgegeven.");
                return Page();
            }

            Domain_bib.Business.Controller con = new Domain_bib.Business.Controller();
            con.DeleteBoek(BoekenId);

            Bericht = "Boek succesvol verwijderd.";
            return Page();
        }
    }
}
