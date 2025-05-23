using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_bib.Business
{
    /// <summary>
    /// Represents a book with properties such as title, author, publisher, language, ISBN, and identifiers.
    /// </summary>
    public class Boek
    {
        // Fields

        /// <summary>
        /// The title of the book.
        /// </summary>
        public string _titel, _auteur, _uitgever, _taal, _isbn;

        /// <summary>
        /// The unique book ID, grade, and genre ID.
        /// </summary>
        public int _boekenId, _graad, _genreId;

        // Properties

        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }

        /// <summary>
        /// Gets or sets the genre ID of the book.
        /// </summary>
        public int GenreId
        {
            get { return _genreId; }
            set { _genreId = value; }
        }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Auteur
        {
            get { return _auteur; }
            set { _auteur = value; }
        }

        /// <summary>
        /// Gets or sets the publisher of the book.
        /// </summary>
        public string Uitgever
        {
            get { return _uitgever; }
            set { _uitgever = value; }
        }

        /// <summary>
        /// Gets or sets the language of the book.
        /// </summary>
        public string Taal
        {
            get { return _taal; }
            set { _taal = value; }
        }

        /// <summary>
        /// Gets or sets the unique book ID.
        /// </summary>
        public int BoekenId
        {
            get { return _boekenId; }
            set { _boekenId = value; }
        }

        /// <summary>
        /// Gets or sets the grade of the book.
        /// </summary>
        public int Graad
        {
            get { return _graad; }
            set { _graad = value; }
        }

        /// <summary>
        /// Gets or sets the ISBN of the book.
        /// </summary>
        public string Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Boek"/> class with default values.
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
        /// Initializes a new instance of the <see cref="Boek"/> class with specified values.
        /// </summary>
        /// <param name="titel">The title of the book.</param>
        /// <param name="genreId">The genre ID.</param>
        /// <param name="auteur">The author of the book.</param>
        /// <param name="uitgever">The publisher of the book.</param>
        /// <param name="taal">The language of the book.</param>
        /// <param name="boekenId">The unique book ID.</param>
        /// <param name="graad">The grade of the book.</param>
        /// <param name="isbn">The ISBN of the book.</param>
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
        /// Returns a string that represents the current book.
        /// </summary>
        /// <returns>A string containing the book ID, title, and author.</returns>
        public override string ToString()
        {
            return $"{_boekenId}: , Titel: {_titel}, Auteur: {_auteur}";
        }
    }
}
