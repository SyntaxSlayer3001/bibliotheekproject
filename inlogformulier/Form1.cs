using Domain_bib.Business;
using System;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Represents the login form for the library system.
    /// Handles user authentication and navigation to the appropriate user interface based on user rights.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        private readonly Controller controller = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the login button click event.
        /// Authenticates the user and opens the corresponding form based on their rights.
        /// </summary>
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text;
            string password = tbWachtwoord.Text;

            var boekmapper = new Domain_bib.Persistence.Boekmapper();
            int? rechtId = boekmapper.GetRechtId(email, password);

            if (rechtId.HasValue)
            {
                MessageBox.Show("Login successful!");
                Form nextForm = rechtId switch
                {
                    1 => new Leeraarscherm(),
                    2 => new Gebruikerscherm(),
                    3 => new Beheerderscherm(),
                    _ => null
                };
                if (nextForm != null)
                {
                    nextForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown RechtID.");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        /// <summary>
        /// Shows the password in the password textbox when the mouse button is held down.
        /// </summary>
        private void btnShowPassword_MouseDown(object sender, EventArgs e) =>
            tbWachtwoord.UseSystemPasswordChar = false;

        /// <summary>
        /// Hides the password in the password textbox when the mouse button is released.
        /// </summary>
        private void btnShowPassword_MouseUp(object sender, EventArgs e) =>
            tbWachtwoord.UseSystemPasswordChar = true;
    }
}
