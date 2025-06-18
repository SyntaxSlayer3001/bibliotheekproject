using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLoginApp.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBibliotheek.Pages
{
    /// <summary>
    /// PageModel voor de loginpagina van het bibliotheeksysteem.
    /// Verwerkt gebruikersinvoer, authenticatie en foutafhandeling.
    /// </summary>
    public class LoginModel : PageModel
    {
        /// <summary>
        /// Databasecontext voor toegang tot gebruikersgegevens.
        /// </summary>
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="LoginModel"/>.
        /// </summary>
        /// <param name="context">De databasecontext die wordt geïnjecteerd via dependency injection.</param>
        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
            LoginData = new LoginInput(); // Initialiseer het loginmodel
            ErrorMessage = string.Empty;  // Standaard geen foutmelding
        }

        /// <summary>
        /// Gebonden property voor de login-invoer (username en password).
        /// Wordt automatisch gevuld vanuit het formulier.
        /// </summary>
        [BindProperty]
        public LoginInput LoginData { get; set; }

        /// <summary>
        /// Eigenschap voor het tonen van foutmeldingen aan de gebruiker.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Wordt aangeroepen bij een POST-verzoek (wanneer de gebruiker probeert in te loggen).
        /// Valideert de invoer, controleert de gebruikersgegevens en handelt de login af.
        /// </summary>
        /// <returns>Redirect naar Overzicht bij succes, anders herlaad de pagina met foutmelding.</returns>
        public async Task<IActionResult> OnPostAsync()
        {
            // Controleer of de modelvalidatie is geslaagd (alle verplichte velden ingevuld)
            if (!ModelState.IsValid)
                return Page();

            // Zoek de gebruiker op basis van e-mail en wachtwoord
            var user = _context.Users.FirstOrDefault(u =>
                u.Email == LoginData.Username && u.Wachtwoord == LoginData.Password);

            if (user != null)
            {
                // Hier zou je echte loginlogica plaatsen (bijv. cookie/session instellen)
                return RedirectToPage("/Overzicht"); // Login geslaagd, ga naar overzichtspagina
            }

            // Login mislukt: toon foutmelding
            ErrorMessage = "Invalid username or password";
            return Page();
        }

        /// <summary>
        /// Model voor de login-invoer (gebruikersnaam en wachtwoord).
        /// Wordt gebruikt voor binding met het formulier.
        /// </summary>
        public class LoginInput
        {
            /// <summary>
            /// De gebruikersnaam (in dit geval het e-mailadres).
            /// </summary>
            [Required]
            public string Username { get; set; } = string.Empty;

            /// <summary>
            /// Het wachtwoord van de gebruiker.
            /// </summary>
            [Required]
            public string Password { get; set; } = string.Empty;
        }
    }
}
