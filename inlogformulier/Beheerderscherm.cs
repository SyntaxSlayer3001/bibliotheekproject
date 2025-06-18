using Domain_bib.Business;
using Domain_bib.Persistence;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace inlogformulier
{
    /// <summary>
    /// Vertegenwoordigt het beheerdersscherm voor het beheren van boeken en gebruikers in het bibliotheeksysteem.
    /// Biedt UI-acties voor toevoegen, bijwerken, verwijderen en verversen van boeken en gebruikers.
    /// </summary>
    public partial class Beheerderscherm : Form
    {
        /// <summary>
        /// Controller-instantie voor businesslogica-operaties.
        /// </summary>
        private readonly Controller conn = new();

        /// <summary>
        /// Initialiseert een nieuwe instantie van het <see cref="Beheerderscherm"/>.
        /// Laadt de lijst met boeken en gebruikers bij het opstarten.
        /// </summary>
        public Beheerderscherm()
        {
            InitializeComponent(); // Initialiseert de UI-componenten
            LoadBoeken();          // Laadt de boekenlijst in de UI
            LoadGebruikers();      // Laadt de gebruikerslijst in de UI
        }

        /// <summary>
        /// Laadt de lijst met boeken uit de database en toont deze in de UI.
        /// </summary>
        private void LoadBoeken()
        {
            var mapper = new Domain_bib.Persistence.Boekmapper(); // Maak een nieuwe Boekmapper aan
            var boekenlijst = mapper.GetBoeken();                  // Haal alle boeken op
            tbBoekenlijst.Items.Clear();                           // Maak de lijst in de UI leeg
            foreach (var boeken in boekenlijst)
            {
                tbBoekenlijst.Items.Add(boeken);                   // Voeg elk boek toe aan de UI-lijst
            }
        }

        /// <summary>
        /// Laadt de lijst met gebruikers uit de database en toont deze in de UI.
        /// </summary>
        private void LoadGebruikers()
        {
            listBoxGebruikers.Items.Clear();                       // Maak de gebruikerslijst in de UI leeg
            var gebruikers = conn.GetGebruikers();                 // Haal alle gebruikers op via de controller
            foreach (var gebruiker in gebruikers)
            {
                // Voeg elke gebruiker toe aan de lijstbox met ID, naam en voornaam
                listBoxGebruikers.Items.Add(
                    $"{gebruiker.GebruikerId}: Naam: {gebruiker.Naam}, Voornaam: {gebruiker.Voornaam}"
                );
            }
        }

        /// <summary>
        /// Opent het formulier om een nieuw boek toe te voegen.
        /// </summary>
        private void btnAddboek_Click(object sender, EventArgs e)
        {
            using var form = new Toevoegscherm(); // Maak een nieuw Toevoegscherm aan
            form.ShowDialog();                    // Toon het formulier als dialoog
        }

        /// <summary>
        /// Ververs de lijsten met boeken en gebruikers in de UI.
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBoeken();      // Herlaad de boekenlijst
            LoadGebruikers();  // Herlaad de gebruikerslijst
        }

        /// <summary>
        /// Opent het formulier om een nieuwe gebruiker toe te voegen.
        /// </summary>
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            using var form = new ToevoegGebruiker(); // Maak een nieuw ToevoegGebruiker-formulier aan
            form.ShowDialog();                       // Toon het formulier als dialoog
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
            conn.DeleteBoek(boekenId);               // Verwijder het boek via de controller
            MessageBox.Show("Boek is verwijderd.");  // Bevestig verwijdering
            LoadBoeken();                            // Ververs de boekenlijst
        }

        /// <summary>
        /// Werkt een gebruiker bij na het opvragen van een geldig gebruiker-ID en nieuwe gegevens.
        /// </summary>
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om het GebruikerID in te voeren
            string input = Interaction.InputBox("Geef het GebruikerID van de gebruiker die je wilt updaten:", "GebruikerID invoeren", "");
            if (!int.TryParse(input, out int gebruikerId) || gebruikerId <= 0)
            {
                MessageBox.Show("Ongeldig GebruikerID."); // Toon foutmelding bij ongeldige invoer
                return;
            }

            var mapper = new Boekmapper(); // Maak een nieuwe Boekmapper aan
            var gebruiker = mapper.GetGebruikerById(gebruikerId); // Haal de gebruiker op
            if (gebruiker == null)
            {
                MessageBox.Show("Gebruiker niet gevonden."); // Toon melding als gebruiker niet bestaat
                return;
            }

            // Vraag nieuwe gegevens op, met bestaande waarden als standaard
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
                MessageBox.Show("Ongeldig RechtID."); // Toon foutmelding bij ongeldige invoer
                return;
            }

            // Werk de gebruiker bij via de controller
            conn.UpdateGebruiker(gebruikerId, email, naam, voornaam, wachtwoord, rechtId);
            MessageBox.Show("Gebruiker is bijgewerkt."); // Bevestig update
            // Eventueel: gebruikerslijst verversen
        }

        /// <summary>
        /// Verwijdert een gebruiker na het opvragen van een geldig gebruiker-ID.
        /// </summary>
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Vraag de gebruiker om het GebruikerID in te voeren
            string input = Interaction.InputBox("Geef het GebruikerID van de gebruiker die je wilt verwijderen:", "GebruikerID invoeren", "");
            if (!int.TryParse(input, out int gebruikerId) || gebruikerId <= 0)
            {
                MessageBox.Show("Ongeldig GebruikerID."); // Toon foutmelding bij ongeldige invoer
                return;
            }
            conn.DeleteGebruiker(gebruikerId);           // Verwijder de gebruiker via de controller
            MessageBox.Show("Gebruiker is verwijderd.");  // Bevestig verwijdering
            // Hier kun je eventueel een methode aanroepen om de gebruikerslijst te verversen
        }

        /// <summary>
        /// Logt de beheerder uit en opent het inlogscherm.
        /// </summary>
        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            Form form = new Form1(); // Maak een nieuw inlogformulier aan
            form.Show();             // Toon het inlogformulier
            this.Close();            // Sluit het beheerdersscherm na het uitloggen
        }
    }
}

