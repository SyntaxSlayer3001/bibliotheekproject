using Domain_bib.Business;
using Domain_bib.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static inlogformulier.Toevoegscherm;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;

namespace inlogformulier
{
    /// <summary>
    /// Represents the form for adding a new user to the library system.
    /// Provides UI actions for entering user details and submitting them to the database.
    /// </summary>
    public partial class ToevoegGebruiker : Form
    {
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        Controller conn = new Controller();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToevoegGebruiker"/> class.
        /// </summary>
        public ToevoegGebruiker()
        {
            InitializeComponent();
            LoadRechten();
        }

        /// <summary>
        /// Handles the click event for the "Toevoegen Gebruiker" button.
        /// Collects user input, adds the user to the database, and clears the input fields.
        /// </summary>
        private void btnToevoegenGebruiker_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string naam = tbNaam.Text.Trim();
            string voornaam = tbVoornaam.Text.Trim();
            string wachtwoord = tbWachtwoord.Text.Trim();
            int rechtId = (int)comboBoxRechtId.SelectedValue;

            MessageBox.Show("Gebruiker toegevoegd");
            conn.InsertGebruiker(email, naam, voornaam, wachtwoord, rechtId);

            tbEmail.Clear();
            tbNaam.Clear();
            tbVoornaam.Clear();
            tbWachtwoord.Clear();
            comboBoxRechtId.SelectedValue = - 1;
        }

        private void LoadRechten()
        {
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var Rechten = new List<Recht>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RechtID, Omschrijving FROM tblrechten";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Rechten.Add(new Recht
                        {
                            RechtID = reader.GetInt32("RechtID"),
                            Omschrijving = reader.GetString("Omschrijving")
                        });
                    }
                }
            }

            comboBoxRechtId.DataSource = Rechten;
            comboBoxRechtId.DisplayMember = "Omschrijving";
            comboBoxRechtId.ValueMember = "RechtID";
        }
        public class Recht
                    {
            public int RechtID { get; set; }
            public string Omschrijving { get; set; }
            
        }
    }
}
