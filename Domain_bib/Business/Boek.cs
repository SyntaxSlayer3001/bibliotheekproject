using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    /// <summary>
    /// Klasse die een boek voorstelt met eigenschappen zoals titel, auteur, uitgever, taal, ISBN en diverse ID's.
    /// </summary>
    public class Boek
    {
        // Velden

        /// <summary>
        /// De titel, auteur, uitgever, taal en ISBN van het boek.
        /// </summary>
        public string _titel, _auteur, _uitgever, _taal, _isbn;

        /// <summary>
        /// Het unieke boek-ID, de graad en het genre-ID van het boek.
        /// </summary>
        public int _boekenId, _graad, _genreId;

        // Properties

        /// <summary>
        /// Geeft de titel van het boek.
        /// </summary>
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        /// <summary>
        /// Geeft het genre-ID van het boek.
        /// </summary>
        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        /// <summary>
        /// Geeft de auteur van het boek.
        /// </summary>
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        /// <summary>
        /// Geeft de uitgever van het boek.
        /// </summary>
        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }

        /// <summary>
        /// Geeft de taal van het boek.
        /// </summary>
        public string Taal
        {
            get { return _taal; }
            set { _taal = value; }
        }

        /// <summary>
        /// Geeft het unieke boek-ID.
        /// </summary>
        public int BoekenId
        {
            get { return _boekenId; }
            set { _boekenId = value; }
        }

        /// <summary>
        /// Geeft de graad van het boek.
        /// </summary>
        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }

        /// <summary>
        /// Geeft het ISBN van het boek.
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        /// <summary>
        /// Standaard constructor. Initialiseert een nieuw boek met lege of standaardwaarden.
        /// </summary>
        public Boek()
        {
            _titel = "";
            _genreId = 0;
            _auteur = "";
            _uitgever = "";
            _taal = "";
            _boekenId = 0;
            _graad = 0;
            _isbn = "";
        }

        /// <summary>
        /// Constructor waarmee alle eigenschappen van het boek direct ingesteld kunnen worden.
        /// </summary>
        /// <param name="titel">De titel van het boek.</param>
        /// <param name="genreId">Het genre-ID.</param>
        /// <param name="auteur">De auteur van het boek.</param>
        /// <param name="uitgever">De uitgever van het boek.</param>
        /// <param name="taal">De taal van het boek.</param>
        /// <param name="boekenId">Het unieke boek-ID.</param>
        /// <param name="graad">De graad van het boek.</param>
        /// <param name="isbn">Het ISBN van het boek.</param>
        public Boek(string titel, int genreId, string auteur, string uitgever, string taal, int boekenId, int graad, string isbn)
        {
            _titel = titel;
            _genreId = genreId;
            _auteur = auteur;
            _uitgever = uitgever;
            _taal = taal;
            _boekenId = boekenId;
            _graad = graad;
            _isbn = isbn;
        }

        /// <summary>
        /// Geeft een stringrepresentatie van het boek terug, bestaande uit ID, titel en auteur.
        /// </summary>
        /// <returns>String met boek-ID, titel en auteur.</returns>
        public override string ToString()
        {
            return $"{_boekenId}: Titel: {_titel}, Auteur: {_auteur}";
        }
    }
}
