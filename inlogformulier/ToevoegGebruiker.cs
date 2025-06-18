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
    /// Vertegenwoordigt het formulier voor het toevoegen van een nieuwe gebruiker aan het bibliotheeksysteem.
    /// Biedt UI-acties voor het invoeren van gebruikersgegevens en het opslaan in de database.
    /// </summary>
    public partial class ToevoegGebruiker : Form
    {
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        Controller conn = new Controller();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="ToevoegGebruiker"/>-formulier.
        /// </summary>
        public ToevoegGebruiker()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadRechten();         // Laadt de rechten (rollen) in de combobox
        }

        /// <summary>
        /// Verwerkt het klikken op de knop "Toevoegen Gebruiker".
        /// Verzamelt gebruikersinvoer, voegt de gebruiker toe aan de database en wist de invoervelden.
        /// </summary>
        private void btnToevoegenGebruiker_Click(object sender, EventArgs e)
        {
            // Haal de waarden uit de tekstvakken en combobox
            string email = tbEmail.Text.Trim();
            string naam = tbNaam.Text.Trim();
            string voornaam = tbVoornaam.Text.Trim();
            string wachtwoord = tbWachtwoord.Text.Trim();
            int rechtId = (int)comboBoxRechtId.SelectedValue;

            MessageBox.Show("Gebruiker toegevoegd"); // Bevestig toevoegen aan de gebruiker
            conn.InsertGebruiker(email, naam, voornaam, wachtwoord, rechtId); // Voeg gebruiker toe via de controller

            // Maak de invoervelden leeg voor een volgende invoer
            tbEmail.Clear();
            tbNaam.Clear();
            tbVoornaam.Clear();
            tbWachtwoord.Clear();
            comboBoxRechtId.SelectedValue = -1;
        }

        /// <summary>
        /// Laadt de beschikbare rechten (rollen) uit de database en vult de combobox.
        /// </summary>
        private void LoadRechten()
        {
            // Connection string voor de MySQL-database
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var Rechten = new List<Recht>();

            // Maak verbinding met de database en haal alle rechten op
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RechtID, Omschrijving FROM tblrechten";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Voeg elk recht toe aan de lijst
                        Rechten.Add(new Recht
                        {
                            RechtID = reader.GetInt32("RechtID"),
                            Omschrijving = reader.GetString("Omschrijving")
                        });
                    }
                }
            }

            // Koppel de rechtenlijst aan de combobox
            comboBoxRechtId.DataSource = Rechten;
            comboBoxRechtId.DisplayMember = "Omschrijving"; // Toon de omschrijving in de UI
            comboBoxRechtId.ValueMember = "RechtID";       // Gebruik RechtID als waarde
        }

        /// <summary>
        /// Klasse die een recht (rol) van een gebruiker voorstelt.
        /// </summary>
        public class Recht
        {
            /// <summary>
            /// Het unieke ID van het recht.
            /// </summary>
            public int RechtID { get; set; }
            /// <summary>
            /// De omschrijving van het recht (bijv. "Beheerder", "Gebruiker", "Leerkracht").
            /// </summary>
            public string Omschrijving { get; set; }
        }
    }
}
