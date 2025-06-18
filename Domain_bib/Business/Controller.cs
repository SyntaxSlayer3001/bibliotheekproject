using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Domain_bib.Business
{
    /// <summary>
    /// Biedt methoden om boeken, gebruikers en leningen te beheren in het bibliotheeksysteem.
    /// Vormt de schakel tussen de businesslaag en de persistencelaag.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Instantie van de persistencelaag voor boek- en gebruikersoperaties.
        /// </summary>
        private Persistence.Boekmapper _bibliotheek;

        /// <summary>
        /// Huidig boek (gereserveerd voor toekomstig gebruik, momenteel niet gebruikt).
        /// </summary>
        private Boek boek;

        /// <summary>
        /// Lijst van boeken die door de controller wordt beheerd.
        /// </summary>
        private List<Boek> _boekenlijst;

        /// <summary>
        /// Initialiseert een nieuwe instantie van de <see cref="Controller"/> klasse.
        /// Laadt de lijst met boeken uit de persistencelaag.
        /// </summary>
        public Controller()
        {
            // Maak een nieuwe instantie van de Boekmapper aan voor database-operaties
            _bibliotheek = new Persistence.Boekmapper();
            // Haal de lijst met boeken op uit de database en sla deze lokaal op
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        /// <summary>
        /// Haalt de huidige lijst met boeken op of stelt deze in.
        /// </summary>
        public List<Boek> GetBoeken
        {
            get { return _boekenlijst; }
            set { _boekenlijst = value; }
        }

        /// <summary>
        /// Voegt een nieuw boek toe aan de bibliotheek en ververst de boekenlijst.
        /// </summary>
        /// <param name="titel">De titel van het boek.</param>
        /// <param name="genreId">Het genre-ID.</param>
        /// <param name="auteur">De auteur van het boek.</param>
        /// <param name="uitgever">De uitgever van het boek.</param>
        /// <param name="taalId">Het taal-ID van het boek.</param>
        /// <param name="graad">De graad van het boek.</param>
        /// <param name="isbn">Het ISBN van het boek.</param>
        public void InsertBoek(string titel, int genreId, string auteur, string uitgever, int taalId, int graad, string isbn)
        {
            // Voeg een nieuw boek toe via de persistencelaag
            _bibliotheek.InsertBoek(titel, genreId, auteur, uitgever, taalId, graad, isbn);
            // Vernieuw de lokale boekenlijst na toevoegen
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        /// <summary>
        /// Voegt een nieuwe gebruiker toe aan het bibliotheeksysteem.
        /// </summary>
        /// <param name="email">Het e-mailadres van de gebruiker.</param>
        /// <param name="naam">De achternaam van de gebruiker.</param>
        /// <param name="voornaam">De voornaam van de gebruiker.</param>
        /// <param name="wachtwoord">Het wachtwoord van de gebruiker.</param>
        /// <param name="rechtId">Het rechtenniveau van de gebruiker.</param>
        public void InsertGebruiker(string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            // Voeg een nieuwe gebruiker toe via de persistencelaag
            _bibliotheek.InsertGebruiker(email, naam, voornaam, wachtwoord, rechtId);
        }

        /// <summary>
        /// Voegt een nieuwe lening toe aan het bibliotheeksysteem.
        /// </summary>
        /// <param name="leningId">Het lening-ID (momenteel niet gebruikt).</param>
        /// <param name="uitleendatum">De datum waarop het boek is uitgeleend.</param>
        /// <param name="terugbrengdatum">De datum waarop het boek teruggebracht moet worden.</param>
        public void InsertLening(int leningId, DateOnly uitleendatum, DateOnly terugbrengdatum)
        {
            // Voeg een nieuwe lening toe via de persistencelaag
            _bibliotheek.InsertLening(uitleendatum, terugbrengdatum);
        }

        /// <summary>
        /// Werkt een bestaande gebruiker bij in het bibliotheeksysteem.
        /// </summary>
        /// <param name="gebruikerId">De unieke ID van de gebruiker.</param>
        /// <param name="email">Het e-mailadres van de gebruiker.</param>
        /// <param name="naam">De achternaam van de gebruiker.</param>
        /// <param name="voornaam">De voornaam van de gebruiker.</param>
        /// <param name="wachtwoord">Het wachtwoord van de gebruiker.</param>
        /// <param name="rechtId">Het rechtenniveau van de gebruiker.</param>
        public void UpdateGebruiker(int gebruikerId, string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            // Werk de gegevens van een bestaande gebruiker bij via de persistencelaag
            _bibliotheek.UpdateGebruiker(gebruikerId, email, naam, voornaam, wachtwoord, rechtId);
        }

        /// <summary>
        /// Verwijdert een gebruiker uit het bibliotheeksysteem.
        /// </summary>
        /// <param name="gebruikerId">De unieke ID van de gebruiker die verwijderd moet worden.</param>
        public void DeleteGebruiker(int gebruikerId)
        {
            // Verwijder een gebruiker via de persistencelaag
            _bibliotheek.DeleteGebruiker(gebruikerId);
        }

        /// <summary>
        /// Werkt een bestaand boek bij in de bibliotheek.
        /// </summary>
        /// <param name="boekenId">Het unieke boek-ID.</param>
        /// <param name="titel">De titel van het boek.</param>
        /// <param name="genreId">Het genre-ID.</param>
        /// <param name="auteur">De auteur van het boek.</param>
        /// <param name="uitgever">De uitgever van het boek.</param>
        /// <param name="taal">Het taal-ID van het boek.</param>
        /// <param name="graad">De graad van het boek.</param>
        /// <param name="isbn">Het ISBN van het boek.</param>
        public void UpdateBoek(int boekenId, string titel, int genreId, string auteur, string uitgever, int taal, int graad, string isbn)
        {
            // Werk de gegevens van een bestaand boek bij via de persistencelaag
            _bibliotheek.UpdateBoek(boekenId, titel, genreId, auteur, uitgever, taal, graad, isbn);
        }

        /// <summary>
        /// Verwijdert een boek uit de bibliotheek en ververst de boekenlijst.
        /// </summary>
        /// <param name="boekenId">Het unieke boek-ID dat verwijderd moet worden.</param>
        public void DeleteBoek(int boekenId)
        {
            // Verwijder een boek via de persistencelaag
            _bibliotheek.DeleteBoek(boekenId);
            // Vernieuw de lokale boekenlijst na verwijderen
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        /// <summary>
        /// Haalt alle gebruikers op uit het bibliotheeksysteem.
        /// </summary>
        /// <returns>Een lijst van alle gebruikers.</returns>
        public List<Gebruiker> GetGebruikers()
        {
            // Haal alle gebruikers op via de persistencelaag
            return _bibliotheek.GetGebruikers();
        }

        /// <summary>
        /// Haalt een boek op aan de hand van het unieke boek-ID.
        /// </summary>
        /// <param name="boekenId">Het unieke ID van het boek.</param>
        /// <returns>Het boek met het opgegeven ID, of null als het niet bestaat.</returns>
        public Boek GetBoekById(int boekenId)
        {
            // Haal een boek op via de persistencelaag op basis van ID
            return _bibliotheek.GetBoekById(boekenId);
        }
    }
}

