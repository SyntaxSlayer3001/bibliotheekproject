using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.VisualBasic;
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

namespace inlogformulier
{
    /// <summary>
    /// Vertegenwoordigt het formulier voor het bijwerken van een bestaand boek in het bibliotheeksysteem.
    /// Biedt UI-acties voor het invoeren van nieuwe boekgegevens en het doorvoeren van de update in de database.
    /// </summary>
    public partial class UpdateBoek : Form
    {
        /// <summary>
        /// Het unieke ID van het boek dat geüpdatet moet worden.
        /// </summary>
        private int _boekenId;

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="UpdateBoek"/>-formulier met het opgegeven boek-ID.
        /// Zet het formulier op en vult de genre- en taal-comboboxen.
        /// </summary>
        /// <param name="boekenId">Het unieke ID van het boek dat geüpdatet moet worden.</param>
        public UpdateBoek(int boekenId)
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            _boekenId = boekenId;  // Sla het boek-ID op voor latere updates
            LoadGenres();          // Laad de genres in de combobox
            LoadTalen();           // Laad de talen in de combobox
            //this.Load += UpdateBoek_Load; // (optioneel) Eventhandler voor form load
        }
        
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        Controller conn = new Controller();

        /// <summary>
        /// Verwerkt het klikken op de knop "Update Boek".
        /// Verzamelt de nieuwe boekgegevens, werkt het boek bij in de database en wist de invoervelden.
        /// </summary>
        private void btnUpdateBoek_Click(object sender, EventArgs e)
        {
            // Verzamel de nieuwe waarden uit de invoervelden
            string titel = tbTitelUpdate.Text.Trim();
            int genreId = (int)comboBoxUpdateGenre.SelectedValue;
            string auteur = tbAuteurUpdate.Text.Trim();
            string uitgever = tbUitgeverUpdate.Text.Trim();
            int taal = (int)comboBoxUpdateTaal.SelectedValue;
            int graad = int.TryParse(tbGraadUpdate.Text, out int graadId) ? graadId : 0;
            string isbn = tbISBNUpdate.Text.Trim();

            // Werk het boek bij via de controller
            conn.UpdateBoek(_boekenId, titel, genreId, auteur, uitgever, taal, graad, isbn);
            MessageBox.Show("Boek geüpdatet"); // Bevestig update

            // Maak de invoervelden leeg voor een volgende bewerking
            tbAuteurUpdate.Clear();
            comboBoxUpdateGenre.SelectedIndex = -1;
            tbGraadUpdate.Clear();
            tbISBNUpdate.Clear();
            tbTitelUpdate.Clear();
            comboBoxUpdateTaal.SelectedIndex = -1;
            tbUitgeverUpdate.Clear();
        }

        /// <summary>
        /// Haalt de lijst met genres op uit de database en vult de genre-combobox.
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
            comboBoxUpdateGenre.DataSource = genres;
            comboBoxUpdateGenre.DisplayMember = "Name"; // Toon de naam in de UI
            comboBoxUpdateGenre.ValueMember = "Id";     // Gebruik Id als waarde
        }

        /// <summary>
        /// Haalt de lijst met talen op uit de database en vult de taal-combobox.
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
            comboBoxUpdateTaal.DataSource = talen;
            comboBoxUpdateTaal.DisplayMember = "Name"; // Toon de naam in de UI
            comboBoxUpdateTaal.ValueMember = "Id";     // Gebruik Id als waarde
        }

        /// <summary>
        /// (Optioneel) Eventhandler voor het laden van het formulier.
        /// Kan gebruikt worden om de genre-combobox te configureren.
        /// </summary>
        //private void UpdateBoek_Load(object sender, EventArgs e)
        //{
        //    comboBoxUpdateGenre.DropDownStyle = ComboBoxStyle.DropDownList;
        //    comboBoxUpdateGenre.DataSource = LoadGenres();
        //    comboBoxUpdateGenre.DisplayMember = "Name";
        //    comboBoxUpdateGenre.ValueMember = "Id";
        //}
    }
}
