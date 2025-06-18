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

namespace inlogformulier
{
    /// <summary>
    /// Vertegenwoordigt het formulier voor het toevoegen van een nieuw boek aan het bibliotheeksysteem.
    /// Biedt UI-acties voor het invoeren van boekgegevens en het opslaan in de database.
    /// </summary>
    public partial class Toevoegscherm : Form
    {
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        private readonly Controller conn = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Toevoegscherm"/>-formulier.
        /// </summary>
        public Toevoegscherm()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadGenres();          // Laadt de genres in de combobox
            LoadTalen();           // Laadt de talen in de combobox
        }

        /// <summary>
        /// Verwerkt het klikken op de knop "Toevoegen".
        /// Verzamelt boekgegevens, voegt het boek toe aan de database en wist de invoervelden.
        /// </summary>
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            // Haal de waarden uit de tekstvakken en comboboxen
            string Titel = tbTitel.Text;
            int GenreId = Convert.ToInt32(comboBoxGenreId.SelectedValue);
            int selectedGenreId = (int)comboBoxGenreId.SelectedValue; // (Dubbel, kan evt. weg)
            string Auteur = tbAuteur.Text;
            string Uitgever = tbUitgever.Text;
            int TaalId = (int)comboBoxTaalId.SelectedValue;
            int graad;
            // Controleer of graad een geldig getal is
            if (!int.TryParse(tbGraad.Text, out graad))
            {
                MessageBox.Show("Please enter a valid number for 'graad'.");
                return;
            }
            string isbn = tbISBN.Text;

            // Voeg het boek toe via de controller
            conn.InsertBoek(Titel, GenreId, Auteur, Uitgever, TaalId, graad, isbn);

            MessageBox.Show("Boek is toegevoegd"); // Bevestig toevoegen

            // Maak de invoervelden leeg voor een volgende invoer
            tbTitel.Clear();
            comboBoxGenreId.SelectedIndex = -1;
            tbAuteur.Clear();
            tbUitgever.Clear();
            comboBoxTaalId.SelectedValue = -1;
            tbGraad.Clear();
            tbISBN.Clear();
        }

        /// <summary>
        /// Laadt genres uit de database en vult de genre-combobox.
        /// Maakt verbinding met de MySQL-database, haalt alle genres op uit 'tblGenre'
        /// en vult de combobox met deze lijst.
        /// </summary>
        private void LoadGenres()
        {
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var genres = new List<Genre>();

            // Maak verbinding met de database en haal alle genres op
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT GenreID, GenreNaam FROM tblGenre";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Voeg elk genre toe aan de lijst
                        genres.Add(new Genre
                        {
                            Id = reader.GetInt32("GenreID"),
                            Name = reader.GetString("GenreNaam")
                        });
                    }
                }
            }

            // Koppel de genreslijst aan de combobox
            comboBoxGenreId.DataSource = genres;
            comboBoxGenreId.DisplayMember = "Name"; // Toon de naam in de UI
            comboBoxGenreId.ValueMember = "Id";     // Gebruik Id als waarde
        }

        /// <summary>
        /// Laadt talen uit de database en vult de taal-combobox.
        /// Maakt verbinding met de MySQL-database, haalt alle talen op uit 'tbltaal'
        /// en vult de combobox met deze lijst.
        /// </summary>
        private void LoadTalen()
        {
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var talen = new List<Taal>();

            // Maak verbinding met de database en haal alle talen op
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TaalID, TaalNaam FROM tbltaal";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Voeg elke taal toe aan de lijst
                        talen.Add(new Taal
                        {
                            Id = reader.GetInt32("TaalID"),
                            Name = reader.GetString("TaalNaam")
                        });
                    }
                }
            }

            // Koppel de talenlijst aan de combobox
            comboBoxTaalId.DataSource = talen;
            comboBoxTaalId.DisplayMember = "Name"; // Toon de naam in de UI
            comboBoxTaalId.ValueMember = "Id";     // Gebruik Id als waarde
        }

        /// <summary>
        /// Klasse die een genre voorstelt met een ID en een naam.
        /// </summary>
        public class Genre
        {
            /// <summary>
            /// Het unieke ID van het genre.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// De naam van het genre.
            /// </summary>
            public string Name { get; set; }
        }

        /// <summary>
        /// Klasse die een taal voorstelt met een ID en een naam.
        /// </summary>
        public class Taal
        {
            /// <summary>
            /// Het unieke ID van de taal.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// De naam van de taal.
            /// </summary>
            public string Name { get; set; }
        }
    }
}
