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
    /// Represents the form for updating an existing book in the library system.
    /// Provides UI actions for entering new book details and submitting the update to the database.
    /// </summary>
    public partial class UpdateBoek : Form
    {
        /// <summary>
        /// The unique ID of the book to update.
        /// </summary>
        private int _boekenId;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBoek"/> class with the specified book ID.
        /// Sets up the form and configures the genre ComboBox to only allow selection from the list (no free text).
        /// </summary>
        /// <param name="boekenId">The unique ID of the book to update.</param>
        public UpdateBoek(int boekenId)
        {
            InitializeComponent();
            _boekenId = boekenId;
            LoadGenres();
            LoadTalen();
            //this.Load += UpdateBoek_Load;
        }
        
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        Controller conn = new Controller();

        /// <summary>
        /// Handles the click event for the "Update Boek" button.
        /// Collects updated book input, updates the book in the database, and clears the input fields.
        /// </summary>
        private void btnUpdateBoek_Click(object sender, EventArgs e)
        {
            // Collect new values
            string titel = tbTitelUpdate.Text.Trim();
            int genreId = (int)comboBoxUpdateGenre.SelectedValue;
            string auteur = tbAuteurUpdate.Text.Trim();
            string uitgever = tbUitgeverUpdate.Text.Trim();
            int taal = (int)comboBoxUpdateTaal.SelectedValue;
            int graad = int.TryParse(tbGraadUpdate.Text, out int graadId) ? graadId : 0;
            string isbn = tbISBNUpdate.Text.Trim();

            // Update the book
            conn.UpdateBoek(_boekenId, titel, genreId, auteur, uitgever, taal, graad, isbn);
            MessageBox.Show("Boek geüpdatet");

            // Clear fields
            tbAuteurUpdate.Clear();
            comboBoxUpdateGenre.SelectedIndex = -1;
            tbGraadUpdate.Clear();
            tbISBNUpdate.Clear();
            tbTitelUpdate.Clear();
            comboBoxUpdateTaal.SelectedIndex = -1;
            tbUitgeverUpdate.Clear();
        }

        /// <summary>
        /// Retrieves the list of genres from the database.
        /// </summary>
        /// <returns>A list of genres.</returns>
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

            comboBoxUpdateGenre.DataSource = genres;
            comboBoxUpdateGenre.DisplayMember = "Name";
            comboBoxUpdateGenre.ValueMember = "Id";
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

            comboBoxUpdateTaal.DataSource = talen;
            comboBoxUpdateTaal.DisplayMember = "Name";
            comboBoxUpdateTaal.ValueMember = "Id";
        }
        /// <summary>
        /// Handles the Load event for the UpdateBoek form.
        /// Configures the genre ComboBox to display genres retrieved from the database.
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
