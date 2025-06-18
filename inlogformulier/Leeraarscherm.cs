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
    /// Vertegenwoordigt het leeraarscherm voor het beheren van boeken in het bibliotheeksysteem.
    /// Biedt UI-acties voor toevoegen, bijwerken, verwijderen en verversen van boeken.
    /// </summary>
    public partial class Leeraarscherm : Form
    {
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        Controller conn = new Controller();

        /// <summary>
        /// Lijst met boeken die momenteel uit de database is geladen.
        /// </summary>
        private List<Boek> boekenlijst = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Leeraarscherm"/>-formulier.
        /// Laadt de boekenlijst en koppelt de zoek-eventhandler.
        /// </summary>
        public Leeraarscherm()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadBoeken();          // Laadt de boekenlijst bij het opstarten
            tbZoekTitel.TextChanged += tbZoekTitel_TextChanged; // Koppel eventhandler voor zoeken op titel
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
        /// Opent het formulier om een nieuw boek toe te voegen.
        /// </summary>
        private void btnAddboek_Click(object sender, EventArgs e)
        {
            Form form = new Toevoegscherm(); // Maak een nieuw Toevoegscherm aan
            form.ShowDialog();               // Toon het formulier als dialoog
        }

        /// <summary>
        /// Ververs de boekenlijst in de UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken(); // Herlaad de boekenlijst
        }

        /// <summary>
        /// Opent het formulier om een boek bij te werken, na het opvragen van een geldig boek-ID.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om het BoekID in te voeren
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt updaten:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID."); // Toon foutmelding bij ongeldige invoer
                return;
            }
            Form form = new UpdateBoek(boekenId); // Maak een nieuw UpdateBoek-formulier aan met het opgegeven ID
            form.ShowDialog();                    // Toon het formulier als dialoog
        }

        /// <summary>
        /// Verwijdert een boek na het opvragen van een geldig boek-ID en ververst de lijst.
        /// </summary>
        private void btnDeleteBoek_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om het BoekID in te voeren
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt verwijderen:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID."); // Toon foutmelding bij ongeldige invoer
                return;
            }
            else
            {
                conn.DeleteBoek(boekenId);           // Verwijder het boek via de controller
                MessageBox.Show("Boek is verwijderd."); // Bevestig verwijdering
                LoadBoeken();                        // Ververs de boekenlijst
            }
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
        /// Verwerkt het klikken op de "Uitloggen"-knop.
        /// Opent het inlogformulier en sluit het huidige scherm.
        /// </summary>
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form form = new Form1(); // Maak een nieuw inlogformulier aan
            form.Show();             // Toon het inlogformulier
            this.Close();            // Sluit het huidige scherm
        }
    }
}
