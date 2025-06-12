using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Domain_bib.Business
{
    /// <summary>
    /// Provides methods to manage books and users in the library system.
    /// Handles communication between the business logic and the persistence layer.
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Instance of the persistence layer for book operations.
        /// </summary>
        private Persistence.Boekmapper _bibliotheek;

        /// <summary>
        /// Instance variable for the current book (not used in this class, but reserved for future use).
        /// </summary>
        private Boek boek;

        /// <summary>
        /// List of books managed by the controller.
        /// </summary>
        private List<Boek> _boekenlijst;

        /// <summary>
        /// Initializes a new instance of the <see cref="Controller"/> class.
        /// Loads the list of books from the persistence layer.
        /// </summary>
        public Controller()
        {
            _bibliotheek = new Persistence.Boekmapper();
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        /// <summary>
        /// Gets or sets the current list of books.
        /// </summary>
        public List<Boek> GetBoeken
        {
            get { return _boekenlijst; }
            set { _boekenlijst = value; }
        }

        /// <summary>
        /// Inserts a new book into the library and refreshes the book list.
        /// </summary>
        /// <param name="titel">The title of the book.</param>
        /// <param name="genreId">The genre ID.</param>
        /// <param name="auteur">The author of the book.</param>
        /// <param name="uitgever">The publisher of the book.</param>
        /// <param name="taalId">The language of the book.</param>
        /// <param name="graad">The grade of the book.</param>
        /// <param name="isbn">The ISBN of the book.</param>
        public void InsertBoek(string titel, int genreId, string auteur, string uitgever, int taalId, int graad, string isbn)
        {
            _bibliotheek.InsertBoek(titel, genreId, auteur, uitgever, taalId, graad, isbn);
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        /// <summary>
        /// Inserts a new user into the library system.
        /// </summary>
        /// <param name="email">The user's email address.</param>
        /// <param name="naam">The user's last name.</param>
        /// <param name="voornaam">The user's first name.</param>
        /// <param name="wachtwoord">The user's password.</param>
        /// <param name="rechtId">The user's rights ID.</param>
        public void InsertGebruiker(string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            _bibliotheek.InsertGebruiker(email, naam, voornaam, wachtwoord, rechtId);
        }
        public void InsertLening(int leningId, DateOnly uitleendatum, DateOnly terugbrengdatum)
        {
            _bibliotheek.InsertLening(uitleendatum, terugbrengdatum);
        }
        public void UpdateGebruiker(int gebruikerId, string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            _bibliotheek.UpdateGebruiker(gebruikerId, email, naam, voornaam, wachtwoord, rechtId);
        }

        public void DeleteGebruiker(int gebruikerId)
        {
            _bibliotheek.DeleteGebruiker(gebruikerId);
        }

        /// <summary>
        /// Updates an existing book in the library.
        /// </summary>
        /// <param name="boekenId">The unique book ID.</param>
        /// <param name="titel">The title of the book.</param>
        /// <param name="genreId">The genre ID.</param>
        /// <param name="auteur">The author of the book.</param>
        /// <param name="uitgever">The publisher of the book.</param>
        /// <param name="taal">The language of the book.</param>
        /// <param name="graad">The grade of the book.</param>
        /// <param name="isbn">The ISBN of the book.</param>
        public void UpdateBoek(int boekenId, string titel, int genreId, string auteur, string uitgever, int taal, int graad, string isbn)
        {
            _bibliotheek.UpdateBoek(boekenId, titel, genreId, auteur, uitgever, taal, graad, isbn);
        }

        /// <summary>
        /// Deletes a book from the library and refreshes the book list.
        /// </summary>
        /// <param name="boekenId">The unique book ID to delete.</param>
        public void DeleteBoek(int boekenId)
        {
            _bibliotheek.DeleteBoek(boekenId);
            _boekenlijst = _bibliotheek.GetBoeken();
        }

        public List<Gebruiker> GetGebruikers()
        {
            return _bibliotheek.GetGebruikers();
        }
        //getBoekById method to retrieve a book by its ID
        public Boek GetBoekById(int boekenId)
        {
            return _bibliotheek.GetBoekById(boekenId);
        }
    }
}

