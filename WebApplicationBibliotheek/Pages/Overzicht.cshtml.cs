using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Domain_bib.Persistence;
using Domain_bib.Business;

namespace WebApplicationBibliotheek.Pages
{
    // De OverzichtModel klasse wordt gebruikt als de code-behind voor de Overzicht Razor Page.
    // Deze klasse zorgt voor het ophalen en beschikbaar stellen van een lijst boeken aan de bijbehorende pagina.
    public class OverzichtModel : PageModel
    {
        // Publieke property die een lijst van Boek-objecten bevat.
        // Deze lijst wordt gebruikt in de Razor Page om alle boeken weer te geven.
        public List<Boek> boeken { get; set; }

        // De OnGet-methode wordt automatisch aangeroepen wanneer de pagina via een GET-verzoek wordt opgevraagd.
        // Hierin worden de boeken opgehaald en aan de boeken-property toegekend.
        public void OnGet() 
        {
            // Maak een nieuwe instantie van Boekmapper aan.
            // Boekmapper is verantwoordelijk voor de communicatie met de databron voor boeken.
            var mapper = new Boekmapper();

            // Haal de lijst met boeken op via de GetBoeken-methode van Boekmapper.
            // De opgehaalde lijst wordt toegewezen aan de boeken-property.
            boeken = mapper.GetBoeken();
        }
    }
}
