using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    /// <summary>
    /// Klasse die een gebruiker van het systeem voorstelt.
    /// Bevat eigenschappen zoals naam, wachtwoord, e-mail, voornaam, ID en rechtenniveau.
    /// </summary>
    public class Gebruiker
    {
        // Privévelden voor de eigenschappen van de gebruiker
        private string _naam, _wachtwoord, _email, _voornaam;
        private int _gebruikerId, _RechtID;

        /// <summary>
        /// De achternaam van de gebruiker.
        /// </summary>
        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        /// <summary>
        /// Het wachtwoord van de gebruiker.
        /// </summary>
        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }

        /// <summary>
        /// Het e-mailadres van de gebruiker.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        /// <summary>
        /// De voornaam van de gebruiker.
        /// </summary>
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }

        /// <summary>
        /// De unieke ID van de gebruiker.
        /// </summary>
        public int GebruikerId
        {
            get { return _gebruikerId; }
            set { _gebruikerId = value; }
        }

        /// <summary>
        /// Het rechtenniveau van de gebruiker (bijvoorbeeld beheerder, leraar, leerling).
        /// </summary>
        public int RechtId
        {
            get { return _RechtID; }
            set { _RechtID = value; }
        }

        /// <summary>
        /// Standaard constructor. Initialiseert alle velden met standaardwaarden.
        /// </summary>
        public Gebruiker()
        {
            _naam = string.Empty;
            _wachtwoord = string.Empty;
            _email = string.Empty;
            _voornaam = string.Empty;
            _gebruikerId = 0;
            _RechtID = 0;
        }

        /// <summary>
        /// Constructor waarmee alle eigenschappen van de gebruiker direct ingesteld kunnen worden.
        /// </summary>
        /// <param name="naam">Achternaam van de gebruiker.</param>
        /// <param name="wachtwoord">Wachtwoord van de gebruiker.</param>
        /// <param name="email">E-mailadres van de gebruiker.</param>
        /// <param name="voornaam">Voornaam van de gebruiker.</param>
        /// <param name="gebruikerId">Unieke ID van de gebruiker.</param>
        /// <param name="rechtId">Rechtenniveau van de gebruiker.</param>
        public Gebruiker(string naam, string wachtwoord, string email, string voornaam, int gebruikerId, int rechtId)
        {
            _naam = naam;
            _wachtwoord = wachtwoord;
            _email = email;
            _voornaam = voornaam;
            _gebruikerId = gebruikerId;
            _RechtID = rechtId;
        }

        /// <summary>
        /// Geeft een stringrepresentatie van de gebruiker terug, bestaande uit ID en volledige naam.
        /// </summary>
        /// <returns>String met ID en naam van de gebruiker.</returns>
        public override string ToString()
        {
            return $"ID: {GebruikerId},{Voornaam} {Naam}";
        }
    }
}
