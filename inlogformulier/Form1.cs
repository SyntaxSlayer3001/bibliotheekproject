using Domain_bib.Business;

namespace inlogformulier
{
    public partial class Form1 : Form
    {
        private Controller controller = new Controller();
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
