using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    public class Gebruiker
    {
        private string _naam, _wachtwoord, _email, _voornaam;
        private int _gebruikerId, _RechtID;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        public string Wachtwoord
        {
            get { return _wachtwoord; }
            set { _wachtwoord = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public int GebruikerId
        {
            get { return _gebruikerId; }
            set { _gebruikerId = value; }
        }
        public int RechtId
        {
            get { return _RechtID; }
            set { _RechtID = value; }
        }
        public Gebruiker()
        {
            _naam = string.Empty;
            _wachtwoord = string.Empty;
            _email = string.Empty;
            _voornaam = string.Empty;
            _gebruikerId = 0;
            _RechtID = 0;
        }
        public Gebruiker(string naam, string wachtwoord, string email, string voornaam, int gebruikerId, int rechtId)
        {
            _naam = naam;
            _wachtwoord = wachtwoord;
            _email = email;
            _voornaam = voornaam;
            _gebruikerId = gebruikerId;
            _RechtID = rechtId;
        }
        public override string ToString()
        {
            return $"ID: {GebruikerId},{Voornaam} {Naam}";
        }
    }
}
