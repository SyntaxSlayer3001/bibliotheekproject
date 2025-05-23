using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    public class Boek
    {
        //declaratie van de variabelen
        public string _titel, _auteur, _uitgever, _taal, _isbn;
        public int _boekenId, _graad, _genreId;

        //properties
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }
        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }
        public string Taal
        {
            get { return _taal; }
            set { _taal = value; }
        }
        public int BoekenId
        {
            get { return _boekenId; }
            set { _boekenId = value; }
        }
        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }
        //constructor
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
        //toString
        public override string ToString()
        {
            return $"{_boekenId}: , Titel: {_titel}, Auteur: {_auteur}";
        }
    }
}
