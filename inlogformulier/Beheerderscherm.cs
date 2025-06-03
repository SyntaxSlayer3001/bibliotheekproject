using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Represents the administrator screen for managing books and users in the library system.
    /// Provides UI actions for adding, updating, deleting, and refreshing books and users.
    /// </summary>
    public partial class Beheerderscherm : Form
    {
        /// <summary>
        /// Controller instance for business logic operations.
        /// </summary>
        private readonly Controller conn = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="Beheerderscherm"/> class.
        /// Loads the list of books and users on startup.
        /// </summary>
        public Beheerderscherm()
        {
            InitializeComponent();
            LoadBoeken();
            LoadGebruikers();
        }

        /// <summary>
        /// Loads the list of books from the database and displays them in the UI.
        /// </summary>
        private void LoadBoeken()
        {
            var mapper = new Domain_bib.Persistence.Boekmapper();
            var boekenlijst = mapper.GetBoeken();
            tbBoekenlijst.Items.Clear();
            foreach (var boeken in boekenlijst)
            {
                tbBoekenlijst.Items.Add(boeken);
            }
        }

        /// <summary>
        /// Loads the list of users from the database and displays them in the UI.
        /// </summary>
        private void LoadGebruikers()
        {
            listBoxGebruikers.Items.Clear();
            var gebruikers = conn.GetGebruikers();
            foreach (var gebruiker in gebruikers)
            {
                listBoxGebruikers.Items.Add(
                    $"{gebruiker.GebruikerId}, Naam: {gebruiker.Naam}, Voornaam: {gebruiker.Voornaam}"
                );
            }
        }

        /// <summary>
        /// Opens the form to add a new book.
        /// </summary>
        private void btnAddboek_Click(object sender, EventArgs e)
        {
            using var form = new Toevoegscherm();
            form.ShowDialog();
        }

        /// <summary>
        /// Refreshes the list of books and users displayed in the UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken();
            LoadGebruikers();
        }

        /// <summary>
        /// Opens the form to add a new user.
        /// </summary>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using var form = new ToevoegGebruiker();
            form.ShowDialog();
        }

        /// <summary>
        /// Opens the form to update a book, after prompting for a valid book ID.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Geef het BoekID van het boek dat je wilt updaten:", "BoekID invoeren", "");
            if (!int.TryParse(input, out int boekenId) || boekenId <= 0)
            {
                MessageBox.Show("Ongeldig BoekID.");
                return;
            }
            using var form = new UpdateBoek(boekenId);
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
            conn.DeleteBoek(boekenId);
            MessageBox.Show("Boek is verwijderd.");
            LoadBoeken();
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Geef het GebruikerID van de gebruiker die je wilt updaten:", "GebruikerID invoeren", "");
            if (!int.TryParse(input, out int gebruikerId) || gebruikerId <= 0)
            {
                MessageBox.Show("Ongeldig GebruikerID.");
                return;
            }

            var mapper = new Boekmapper();
            var gebruiker = mapper.GetGebruikerById(gebruikerId);
            if (gebruiker == null)
            {
                MessageBox.Show("Gebruiker niet gevonden.");
                return;
            }

            string email = Interaction.InputBox("Geef het nieuwe e-mailadres:", "E-mail invoeren", gebruiker.Value.Email);
            string naam = Interaction.InputBox("Geef de nieuwe achternaam:", "Achternaam invoeren", gebruiker.Value.Naam);
            string voornaam = Interaction.InputBox("Geef de nieuwe voornaam:", "Voornaam invoeren", gebruiker.Value.Voornaam);
            string wachtwoord = Interaction.InputBox("Geef het nieuwe wachtwoord:", "Wachtwoord invoeren", gebruiker.Value.Wachtwoord);
            string rechtIdInput = Interaction.InputBox("Geef het nieuwe RechtID:", "RechtID invoeren", gebruiker.Value.RechtId.ToString());

            // Gebruik bestaande waarde als het veld leeg is
            if (string.IsNullOrWhiteSpace(email)) email = gebruiker.Value.Email;
            if (string.IsNullOrWhiteSpace(naam)) naam = gebruiker.Value.Naam;
            if (string.IsNullOrWhiteSpace(voornaam)) voornaam = gebruiker.Value.Voornaam;
            if (string.IsNullOrWhiteSpace(wachtwoord)) wachtwoord = gebruiker.Value.Wachtwoord;

            int rechtId;
            if (string.IsNullOrWhiteSpace(rechtIdInput))
                rechtId = gebruiker.Value.RechtId;
            else if (!int.TryParse(rechtIdInput, out rechtId))
            {
                MessageBox.Show("Ongeldig RechtID.");
                return;
            }

            conn.UpdateGebruiker(gebruikerId, email, naam, voornaam, wachtwoord, rechtId);
            MessageBox.Show("Gebruiker is bijgewerkt.");
            // Eventueel: gebruikerslijst verversen
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Geef het GebruikerID van de gebruiker die je wilt verwijderen:", "GebruikerID invoeren", "");
            if (!int.TryParse(input, out int gebruikerId) || gebruikerId <= 0)
            {
                MessageBox.Show("Ongeldig GebruikerID.");
                return;
            }
            conn.DeleteGebruiker(gebruikerId);
            MessageBox.Show("Gebruiker is verwijderd.");
            // Hier kun je eventueel een methode aanroepen om de gebruikerslijst te verversen
        }
    }
}

