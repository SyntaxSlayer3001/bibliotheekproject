using Domain_bib.Persistence;
using Domain_bib.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Vertegenwoordigt het gebruikersscherm voor het bekijken en zoeken van boeken in het bibliotheeksysteem.
    /// Biedt functionaliteit om de boekenlijst te tonen, sorteren en filteren.
    /// </summary>
    public partial class Gebruikerscherm : Form
    {
        /// <summary>
        /// De lijst met boeken die momenteel uit de database is geladen.
        /// </summary>
        private List<Boek> boekenlijst = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Gebruikerscherm"/>.
        /// Laadt de boekenlijst en koppelt de zoek-eventhandler.
        /// </summary>
        public Gebruikerscherm()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadBoeken();          // Laadt de boekenlijst bij het opstarten
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged; // Koppel eventhandler voor zoeken
        }

        /// <summary>
        /// Laadt de lijst met boeken uit de database en toont deze in de UI.
        /// </summary>
        private void LoadBoeken()
        {
            var mapper = new Boekmapper();      // Maak een nieuwe Boekmapper aan
            boekenlijst = mapper.GetBoeken();   // Haal alle boeken op uit de database
            UpdateListBox(boekenlijst);         // Toon de boeken in de lijstbox
        }

        /// <summary>
        /// Werkt de boekenlijst in de UI bij met de opgegeven collectie boeken.
        /// </summary>
        /// <param name="boeken">De collectie boeken die getoond moet worden.</param>
        private void UpdateListBox(IEnumerable<Boek> boeken)
        {
            tbBoekenlijst.Items.Clear();        // Maak de lijstbox leeg
            foreach (var boek in boeken)
            {
                tbBoekenlijst.Items.Add(boek);  // Voeg elk boek toe aan de lijstbox
            }
        }

        /// <summary>
        /// Ververs de boekenlijst in de UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e) => LoadBoeken();

        /// <summary>
        /// Sorteert de boekenlijst oplopend op titel en werkt de weergave bij.
        /// </summary>
        private void btnAflopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderBy(b => b.Titel).ToList(); // Sorteer oplopend op titel
            UpdateListBox(sorted);                                   // Werk de lijstbox bij
        }

        /// <summary>
        /// Sorteert de boekenlijst aflopend op titel en werkt de weergave bij.
        /// </summary>
        private void btnOplopend_Click(object sender, EventArgs e)
        {
            var sorted = boekenlijst.OrderByDescending(b => b.Titel).ToList(); // Sorteer aflopend op titel
            UpdateListBox(sorted);                                             // Werk de lijstbox bij
        }

        /// <summary>
        /// Filtert de boekenlijst op basis van de zoekterm in het titel-zoekveld.
        /// </summary>
        private void tbZoekTitel_TextChanged(object sender, EventArgs e)
        {
            string zoekterm = tbZoekTitel.Text.Trim().ToLower(); // Haal de zoekterm op en maak deze lowercase
            var gefilterd = boekenlijst
                .Where(b => b.Titel != null && b.Titel.ToLower().Contains(zoekterm)) // Filter op titel
                .ToList();
            UpdateListBox(gefilterd); // Toon de gefilterde lijst
        }

        /// <summary>
        /// Logt de gebruiker uit en opent het inlogscherm.
        /// </summary>
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form form = new Form1(); // Maak een nieuw inlogformulier aan
            form.Show();             // Toon het inlogformulier
            this.Close();            // Sluit het huidige scherm
        }

        /// <summary>
        /// Opent het leningenoverzicht en verbergt het huidige scherm.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Leningen leningenForm = new Leningen(); // Maak een nieuw leningenformulier aan
            leningenForm.Show();                    // Toon het leningenformulier
            this.Hide();                            // Verberg het huidige scherm
        }
    }
}
