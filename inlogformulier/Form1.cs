using Domain_bib.Business;
using System;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Vertegenwoordigt het inlogformulier voor het bibliotheeksysteem.
    /// Verwerkt gebruikersauthenticatie en navigeert naar het juiste scherm op basis van gebruikersrechten.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        private readonly Controller controller = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Form1"/>-formulier.
        /// </summary>
        public Form1()
        {
            InitializeComponent(); // Initialiseert de UI-componenten van het formulier
        }

        /// <summary>
        /// Verwerkt het klikken op de login-knop.
        /// Authenticeert de gebruiker en opent het bijbehorende scherm op basis van het RechtID.
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            // Haal de ingevoerde e-mail en wachtwoord op uit de tekstvakken
            string email = tbEmail.Text;
            string password = tbWachtwoord.Text;

            // Maak een nieuwe Boekmapper aan om het RechtID op te halen
            var boekmapper = new Domain_bib.Persistence.Boekmapper();
            int? rechtId = boekmapper.GetRechtId(email, password);

            if (rechtId.HasValue)
            {
                MessageBox.Show("Login successful!"); // Toon succesmelding
                // Bepaal welk scherm geopend moet worden op basis van het RechtID
                Form nextForm = rechtId switch
                {
                    1 => new Leeraarscherm(),      // Leerkracht
                    2 => new Gebruikerscherm(),    // Gebruiker
                    3 => new Beheerderscherm(),    // Beheerder
                    _ => null
                };
                if (nextForm != null)
                {
                    nextForm.Show(); // Toon het juiste scherm
                    this.Hide();     // Verberg het inlogformulier
                }
                else
                {
                    MessageBox.Show("Unknown RechtID."); // Onbekend RechtID
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password."); // Foutmelding bij ongeldige inlog
            }
        }

        /// <summary>
        /// Toont het wachtwoord in het wachtwoordveld zolang de muisknop is ingedrukt.
        /// </summary>
        private void btnShowPassword_MouseDown(object sender, EventArgs e) =>
            tbWachtwoord.UseSystemPasswordChar = false; // Toon het wachtwoord als leesbare tekst

        /// <summary>
        /// Verbergt het wachtwoord in het wachtwoordveld wanneer de muisknop wordt losgelaten.
        /// </summary>
        private void btnShowPassword_MouseUp(object sender, EventArgs e) =>
            tbWachtwoord.UseSystemPasswordChar = true; // Verberg het wachtwoord als sterretjes/bullet
    }
}
