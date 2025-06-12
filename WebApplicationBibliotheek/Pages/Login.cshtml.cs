using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLoginApp.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationBibliotheek.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
            LoginData = new LoginInput();
            ErrorMessage = string.Empty;
        }

        [BindProperty]
        public LoginInput LoginData { get; set; }

        public string ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            var user = _context.Users.FirstOrDefault(u =>
                u.Email == LoginData.Username && u.Wachtwoord == LoginData.Password);

            if (user != null)
            {
                // Replace with actual login logic (e.g., cookie/session)
                return RedirectToPage("/Overzicht");
            }

            ErrorMessage = "Invalid username or password";
            return Page();
        }

        public class LoginInput
        {
            [Required]
            public string Username { get; set; } = string.Empty;

            [Required]
            public string Password { get; set; } = string.Empty;
        }
    }
}
