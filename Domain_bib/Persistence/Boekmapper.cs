using Domain_bib.Business;
using MySql.Data.MySqlClient;

namespace Domain_bib.Persistence
{
    /// <summary>
    /// Handles database operations for books and users in the library system.
    /// Provides methods to insert, update, delete, and retrieve books and users.
    /// </summary>
    public class Boekmapper
    {
        /// <summary>
        /// The connection string used to connect to the MySQL database.
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="Boekmapper"/> class with a default connection string.
        /// </summary>
        public Boekmapper()
        {
            _connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
        }

        /// <summary>
        /// Inserts a new book into the database.
        /// </summary>
        /// <param name="titel">The title of the book.</param>
        /// <param name="GenreId">The genre ID of the book.</param>
        /// <param name="auteur">The author of the book.</param>
        /// <param name="uitgever">The publisher of the book.</param>
        /// <param name="taalId">The language of the book.</param>
        /// <param name="graad">The grade of the book.</param>
        /// <param name="isbn">The ISBN of the book.</param>
        public void InsertBoek(string titel, int GenreId, string auteur, string uitgever, int taalId, int graad, string isbn)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO tblboeken (Titel, GenreId, Auteur, Uitgever, Taal, Graad, ISBN) VALUES (@titel, @genreId, @auteur, @uitgever, @taal, @graad, @isbn)", connection);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@genreId", GenreId);
                command.Parameters.AddWithValue("@auteur", auteur);
                command.Parameters.AddWithValue("@uitgever", uitgever);
                command.Parameters.AddWithValue("@taal", taalId);
                command.Parameters.AddWithValue("@graad", graad);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves all books from the database.
        /// </summary>
        /// <returns>A list of <see cref="Boek"/> objects.</returns>
        public List<Boek> GetBoeken()
        {
            var boekenlijst = new List<Boek>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("select * from tblboeken", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var boek = new Boek
                        {
                            BoekenId = Convert.ToInt32(reader["BoekenId"]),
                            Titel = reader["Titel"].ToString(),
                            GenreId = Convert.ToInt32(reader["GenreId"]),
                            Auteur = reader["Auteur"].ToString(),
                            Uitgever = reader["Uitgever"].ToString(),
                            Taal = reader["Taal"].ToString(),
                            Graad = Convert.ToInt32(reader["Graad"]),
                            Isbn = reader["ISBN"].ToString()
                        };
                        boekenlijst.Add(boek);
                    }
                }
            }
            return boekenlijst;
        }

        /// <summary>
        /// Retrieves the rights ID for a user based on email and password.
        /// </summary>
        /// <param name="email">The user's email address.</param>
        /// <param name="password">The user's password.</param>
        /// <returns>The rights ID if found; otherwise, null.</returns>
        public int? GetRechtId(string email, string password)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT RechtID FROM tblgebruiker WHERE Email = @email AND Wachtwoord = @password";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rechtId))
                        return rechtId;
                    else
                        return null;
                }
            }
        }

        /// <summary>
        /// Retrieves the rights ID for a user based on their user ID.
        /// </summary>
        /// <param name="gebruikerId">The user's unique ID.</param>
        /// <returns>The rights ID if found; otherwise, null.</returns>
        public int? GetRechtIdByGebruikerId(int gebruikerId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT RechtID FROM tblgebruiker WHERE GebruikerID = @GebruikerID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                    var result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int rechtId))
                        return rechtId;
                    else
                        return null;
                }
            }
        }

        /// <summary>
        /// Inserts a new user into the database.
        /// </summary>
        /// <param name="email">The user's email address.</param>
        /// <param name="naam">The user's last name.</param>
        /// <param name="voornaam">The user's first name.</param>
        /// <param name="wachtwoord">The user's password.</param>
        /// <param name="rechtId">The user's rights ID.</param>
        public void InsertGebruiker(string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "INSERT INTO tblgebruiker (Email, Naam, Voornaam, Wachtwoord, RechtID) VALUES (@Email, @Naam, @Voornaam, @Wachtwoord, @RechtID)",
                    connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Naam", naam);
                command.Parameters.AddWithValue("@Voornaam", voornaam);
                command.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
                command.Parameters.AddWithValue("@RechtID", rechtId);
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        public void UpdateGebruiker(int gebruikerId, string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "UPDATE tblgebruiker SET Email = @Email, Naam = @Naam, Voornaam = @Voornaam, Wachtwoord = @Wachtwoord, RechtID = @RechtID WHERE GebruikerID = @GebruikerID",
                    connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Naam", naam);
                command.Parameters.AddWithValue("@Voornaam", voornaam);
                command.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
                command.Parameters.AddWithValue("@RechtID", rechtId);
                command.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteGebruiker(int gebruikerId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM tblgebruiker WHERE GebruikerID = @GebruikerID", connection);
                command.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updates an existing book in the database.
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
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand(
                    "UPDATE tblboeken SET Titel = @titel, GenreId = @genreId, Auteur = @auteur, Uitgever = @uitgever, Taal = @taal, Graad = @graad, ISBN = @isbn WHERE BoekenId = @boekenId",
                    connection);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@genreId", genreId);
                command.Parameters.AddWithValue("@auteur", auteur);
                command.Parameters.AddWithValue("@uitgever", uitgever);
                command.Parameters.AddWithValue("@taal", taal);
                command.Parameters.AddWithValue("@graad", graad);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.Parameters.AddWithValue("@boekenId", boekenId);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Deletes a book from the database.
        /// </summary>
        /// <param name="boekenId">The unique book ID to delete.</param>
        public void DeleteBoek(int boekenId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM tblboeken WHERE BoekenId = @boekenId", connection);
                command.Parameters.AddWithValue("@boekenId", boekenId);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Retrieves a user by their unique ID.
        /// </summary>
        /// <param name="gebruikerId">The user's unique ID.</param>
        /// <returns>A tuple containing the user's email, name, first name, password, and rights ID if found; otherwise, null.</returns>
        public (string Email, string Naam, string Voornaam, string Wachtwoord, int RechtId)? GetGebruikerById(int gebruikerId)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT Email, Naam, Voornaam, Wachtwoord, RechtID FROM tblgebruiker WHERE GebruikerID = @GebruikerID";
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return (
                                reader["Email"].ToString(),
                                reader["Naam"].ToString(),
                                reader["Voornaam"].ToString(),
                                reader["Wachtwoord"].ToString(),
                                Convert.ToInt32(reader["RechtID"])
                            );
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Retrieves all users from the database.
        /// </summary>
        /// <returns>A list of tuples containing user details.</returns>
        public List<Gebruiker> GetGebruikers()
        {
            var gebruikerlijst = new List<Gebruiker>();
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("select * from tblgebruiker", connection);
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var gebruiker = new Gebruiker
                        {
                            GebruikerId = Convert.ToInt32(reader["GebruikerID"]),
                            Naam = reader["Naam"].ToString(),
                            Voornaam = reader["Voornaam"].ToString(),
                            RechtId = Convert.ToInt32(reader["RechtID"]),
                            Wachtwoord = reader["Wachtwoord"].ToString(),
                            Email = reader["Email"].ToString(),
                        };
                        gebruikerlijst.Add(gebruiker);
                    }
                }
            }
            return gebruikerlijst;
        }
    }
}
