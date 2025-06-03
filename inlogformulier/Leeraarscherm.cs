using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.VisualBasic;
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
    /// Represents the teacher screen for managing books in the library system.
    /// Provides UI actions for adding, updating, deleting, and refreshing books.
    /// </summary>
    public partial class Leeraarscherm : Form
    {
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        Controller conn = new Controller();
        private List<Boek> boekenlijst = new();
        /// <summary>
        /// Initializes a new instance of the <see cref="Leeraarscherm"/> class.
        /// Loads the list of books on startup.
        /// </summary>
        public Leeraarscherm()
        {
            InitializeComponent();
            LoadBoeken();
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged;
        }

        /// <summary>
        /// Loads the list of books from the database and displays them in the UI.
        /// </summary>
        private void LoadBoeken()
        {
            var mapper = new Boekmapper();
            boekenlijst = mapper.GetBoeken(); // let op: geen 'var'!
            UpdateListBox(boekenlijst);
        }
        private void UpdateListBox(IEnumerable<Boek> boeken)
        {
            tbBoekenlijst.Items.Clear();
            foreach (var boek in boeken)
            {
                tbBoekenlijst.Items.Add(boek);
            }
        }

        /// <summary>
        /// Opens the form to add a new book.
        /// </summary>
        private void btnAddboek_Click(object sender, EventArgs e)
        {
            Form form = new Toevoegscherm();
            form.ShowDialog();
        }

        /// <summary>
        /// Refreshes the list of books displayed in the UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken();
        }

        /// <summary>
        /// Opens the form to update a book, after prompting for a valid book ID.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Vraag om het BoekID
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt updaten:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID.");
                return;
            }
            Form form = new UpdateBoek(boekenId); // Geef het ID mee
            form.ShowDialog();
        }

        /// <summary>
        /// Deletes a book after prompting for a valid book ID, then refreshes the list.
        /// </summary>
        private void btnDeleteBoek_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt verwijderen:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID.");
                return;
            }
            else
            {
                conn.DeleteBoek(boekenId);
                MessageBox.Show("Boek is verwijderd.");
                LoadBoeken();
            }
        }

        private void tbZoekTitel_TextChanged(object sender, EventArgs e)
        {
            string zoekterm = tbZoekTitel.Text.Trim().ToLower();
            var gefilterd = boekenlijst
                .Where(b => b.Titel != null && b.Titel.ToLower().Contains(zoekterm))
                .ToList();
            UpdateListBox(gefilterd);
        }
    }
}
