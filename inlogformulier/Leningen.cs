using Domain_bib.Business;
using Domain_bib.Persistence;
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
    /// Vertegenwoordigt het leningenoverzicht voor gebruikers.
    /// Biedt functionaliteit om leningen te bekijken en nieuwe leningen toe te voegen.
    /// </summary>
    public partial class Leningen : Form
    {
        /// <summary>
        /// Lijst met leningen die uit de database zijn opgehaald.
        /// </summary>
        private List<Lening> leninglijst = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Leningen"/>-formulier.
        /// Laadt de bestaande leningen bij het opstarten.
        /// </summary>
        public Leningen()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadLeningen();        // Laadt de leningenlijst bij het opstarten
        }

        /// <summary>
        /// Haalt alle leningen op uit de database en toont deze in de UI.
        /// </summary>
        private void LoadLeningen()
        {
            var mapper = new Boekmapper();           // Maak een nieuwe Boekmapper aan
            leninglijst = mapper.getleningen();      // Haal alle leningen op uit de database
            lbUitleningen.Items.Clear();             // Maak de lijstbox leeg
            foreach (var lening in leninglijst)
            {
                lbUitleningen.Items.Add(lening);     // Voeg elke lening toe aan de lijstbox
            }
        }

        /// <summary>
        /// Verwerkt het klikken op de knop om een nieuwe lening toe te voegen.
        /// Leest de geselecteerde datums uit de DateTimePickers, voegt de lening toe en ververst de lijst.
        /// </summary>
        private void btnLening_Click(object sender, EventArgs e)
        {
            try
            {
                // Haal de gekozen start- en einddatum op uit de DateTimePickers
                DateOnly startdatum = DateOnly.FromDateTime(dtpStartdatum.Value);
                DateOnly einddatum = DateOnly.FromDateTime(dtpEinddatum.Value);

                var mapper = new Boekmapper(); // Maak een nieuwe Boekmapper aan
                mapper.InsertLening(startdatum, einddatum); // Voeg de lening toe aan de database

                MessageBox.Show("Lening succesvol toegevoegd!"); // Bevestig toevoegen
                LoadLeningen(); // Ververs de leningenlijst in de UI
            }
            catch (Exception ex)
            {
                // Toon een foutmelding als er iets misgaat bij het toevoegen
                MessageBox.Show("Fout bij toevoegen lening: " + ex.Message);
            }
        }
    }
}
