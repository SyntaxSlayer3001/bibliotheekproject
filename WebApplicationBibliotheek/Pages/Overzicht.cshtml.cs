using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Persistence;
using Domain_bib.Business;

namespace WebApplicationBibliotheek.Pages
{
    public class OverzichtModel : PageModel
    {
        public List<Boek> boeken { get; set; }
        public void OnGet() 
        {
            var mapper = new Boekmapper();
            boeken = mapper.GetBoeken();
        }
    }
}
