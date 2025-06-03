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
    /// Represents the form for adding a new book to the library system.
    /// Provides UI actions for entering book details and submitting them to the database.
    /// </summary>
    public partial class Toevoegscherm : Form
    {
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        private readonly Controller conn = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Toevoegscherm"/> class.
        /// </summary>
        public Toevoegscherm()
        {
            InitializeComponent();
            LoadGenres();
            LoadTalen();
        }

        /// <summary>
        /// Handles the click event for the "Toevoegen" button.
        /// Collects book input, adds the book to the database, and clears the input fields.
        /// </summary>
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string Titel = tbTitel.Text;
            int GenreId = Convert.ToInt32(comboBoxGenreId.SelectedValue);
            int selectedGenreId = (int)comboBoxGenreId.SelectedValue;
            string Auteur = tbAuteur.Text;
            string Uitgever = tbUitgever.Text;
            int TaalId = (int)comboBoxTaalId.SelectedValue;
            int graad;
            if (!int.TryParse(tbGraad.Text, out graad))
            {
                MessageBox.Show("Please enter a valid number for 'graad'.");
                return;
            }
            string isbn = tbISBN.Text;

            conn.InsertBoek(Titel, GenreId, Auteur, Uitgever, TaalId, graad, isbn);

            MessageBox.Show("Boek is toegevoegd");

            tbTitel.Clear();
            comboBoxGenreId.SelectedIndex = -1;
            tbAuteur.Clear();
            tbUitgever.Clear();
            comboBoxTaalId.SelectedValue = -1;
            tbGraad.Clear();
            tbISBN.Clear();
        }

        /// <summary>
        /// Loads genres from the database and populates the genre combo box.
        /// Establishes a connection to the MySQL database, retrieves all genres from the 'tblGenre' table,
        /// and adds them to a list of Genre objects. The comboBoxGenreId is then populated with this list,
        /// displaying the genre name and using the genre ID as the value.
        /// </summary>
        private void LoadGenres()
        {
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var genres = new List<Genre>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT GenreID, GenreNaam FROM tblGenre";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        genres.Add(new Genre
                        {
                            Id = reader.GetInt32("GenreID"),
                            Name = reader.GetString("GenreNaam")
                        });
                    }
                }
            }

            comboBoxGenreId.DataSource = genres;
            comboBoxGenreId.DisplayMember = "Name";
            comboBoxGenreId.ValueMember = "Id";
        }


        private void LoadTalen()
        {
            string connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
            var talen = new List<Taal>();

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TaalID, TaalNaam FROM tbltaal";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        talen.Add(new Taal
                        {
                            Id = reader.GetInt32("TaalID"),
                            Name = reader.GetString("TaalNaam")
                        });
                    }
                }
            }

            comboBoxTaalId.DataSource = talen;
            comboBoxTaalId.DisplayMember = "Name";
            comboBoxTaalId.ValueMember = "Id";
        }
        /// <summary>
        /// Represents a genre with an ID and a name.
        /// </summary>
        public class Genre
        {
            /// <summary>
            /// Gets or sets the ID of the genre.
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// Gets or sets the name of the genre.
            /// </summary>
            public string Name { get; set; }
        }
        public class Taal
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
