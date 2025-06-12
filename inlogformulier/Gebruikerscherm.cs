using Domain_bib.Persistence;
using Domain_bib.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Represents the user screen for viewing and searching books in the library system.
    /// Provides functionality to display, sort, and filter the list of books.
    /// </summary>
    public partial class Gebruikerscherm : Form
    {
        /// <summary>
        /// The list of books currently loaded from the database.
        /// </summary>
        private List<Boek> boekenlijst = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Gebruikerscherm"/> class.
        /// Loads the list of books and sets up the search event handler.
        /// </summary>
        public Gebruikerscherm()
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
            boekenlijst = mapper.GetBoeken();
            UpdateListBox(boekenlijst);
        }

        /// <summary>
        /// Updates the book list display with the provided collection of books.
        /// </summary>
        /// <param name="boeken">The collection of books to display.</param>
        private void UpdateListBox(IEnumerable<Boek> boeken)
        {
            tbBoekenlijst.Items.Clear();
            foreach (var boek in boeken)
            {
                tbBoekenlijst.Items.Add(boek);
            }
        }

        /// <summary>
        /// Refreshes the list of books displayed in the UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e) => LoadBoeken();

        /// <summary>
        /// Sorts the book list in ascending order by title and updates the display.
        /// </summary>
        private void btnAflopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderBy(b => b.Titel).ToList();
            UpdateListBox(sorted);
        }

        /// <summary>
        /// Sorts the book list in descending order by title and updates the display.
        /// </summary>
        private void btnOplopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderByDescending(b => b.Titel).ToList();
            UpdateListBox(sorted);
        }

        /// <summary>
        /// Filters the book list based on the search term entered in the title search box.
        /// </summary>
        private void tbZoekTitel_TextChanged(object sender, EventArgs e)
        {
            string zoekterm = tbZoekTitel.Text.Trim().ToLower();
            var gefilterd = boekenlijst
                .Where(b => b.Titel != null && b.Titel.ToLower().Contains(zoekterm))
                .ToList();
            UpdateListBox(gefilterd);
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form form = new Form1();
            form.Show();
            this.Close(); // Hide the current form instead of closing it
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Leningen leningenForm = new Leningen();
            leningenForm.Show();
            this.Hide(); // Hide the current form instead of closing it
        }
    }
}
