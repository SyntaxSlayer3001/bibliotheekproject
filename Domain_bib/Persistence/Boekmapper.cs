using Domain_bib.Business;
using MySql.Data.MySqlClient;

namespace Domain_bib.Persistence
{
    /// <summary>
    /// Verzorgt database-operaties voor boeken, gebruikers en leningen in het bibliotheeksysteem.
    /// Biedt methoden om boeken en gebruikers toe te voegen, te wijzigen, te verwijderen en op te halen.
    /// </summary>
    public class Boekmapper
    {
        /// <summary>
        /// De connection string die gebruikt wordt om verbinding te maken met de MySQL-database.
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Initialiseert een nieuwe instantie van de <see cref="Boekmapper"/> klasse met een standaard connection string.
        /// </summary>
        public Boekmapper()
        {
            // Connection string voor de lokale MySQL-database
            _connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
        }

        /// <summary>
        /// Voegt een nieuw boek toe aan de database.
        /// </summary>
        public void InsertBoek(string titel, int GenreId, string auteur, string uitgever, int taalId, int graad, string isbn)
        {
            // Maak verbinding met de database en voer een INSERT-query uit
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
        /// Haalt alle boeken op uit de database.
        /// </summary>
        /// <returns>Lijst van <see cref="Boek"/> objecten.</returns>
        public List<Boek> GetBoeken()
        {
            var boekenlijst = new List<Boek>();
            // Maak verbinding met de database en voer een SELECT-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("select * from tblboeken", connection);
                using (var reader = command.ExecuteReader())
                {
                    // Lees alle rijen uit de resultset en maak Boek-objecten aan
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
        /// Haalt het rechtenniveau op van een gebruiker op basis van e-mail en wachtwoord.
        /// </summary>
        /// <returns>RechtID indien gevonden, anders null.</returns>
        public int? GetRechtId(string email, string password)
        {
            // Zoek het rechtenniveau van de gebruiker met opgegeven e-mail en wachtwoord
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
        /// Haalt het rechtenniveau op van een gebruiker op basis van zijn/haar ID.
        /// </summary>
        /// <returns>RechtID indien gevonden, anders null.</returns>
        public int? GetRechtIdByGebruikerId(int gebruikerId)
        {
            // Zoek het rechtenniveau van de gebruiker met opgegeven ID
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
        /// Voegt een nieuwe gebruiker toe aan de database.
        /// </summary>
        public void InsertGebruiker(string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            // Maak verbinding met de database en voer een INSERT-query uit
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

        /// <summary>
        /// Wijzigt een bestaande gebruiker in de database.
        /// </summary>
        public void UpdateGebruiker(int gebruikerId, string email, string naam, string voornaam, string wachtwoord, int rechtId)
        {
            // Maak verbinding met de database en voer een UPDATE-query uit
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

        /// <summary>
        /// Verwijdert een gebruiker uit de database.
        /// </summary>
        public void DeleteGebruiker(int gebruikerId)
        {
            // Maak verbinding met de database en voer een DELETE-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM tblgebruiker WHERE GebruikerID = @GebruikerID", connection);
                command.Parameters.AddWithValue("@GebruikerID", gebruikerId);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Wijzigt een bestaand boek in de database.
        /// </summary>
        public void UpdateBoek(int boekenId, string titel, int genreId, string auteur, string uitgever, int taal, int graad, string isbn)
        {
            // Maak verbinding met de database en voer een UPDATE-query uit
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
        /// Verwijdert een boek uit de database.
        /// </summary>
        public void DeleteBoek(int boekenId)
        {
            // Maak verbinding met de database en voer een DELETE-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("DELETE FROM tblboeken WHERE BoekenId = @boekenId", connection);
                command.Parameters.AddWithValue("@boekenId", boekenId);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Haalt een gebruiker op op basis van zijn/haar ID.
        /// </summary>
        /// <returns>Tuple met gebruikersgegevens indien gevonden, anders null.</returns>
        public (string Email, string Naam, string Voornaam, string Wachtwoord, int RechtId)? GetGebruikerById(int gebruikerId)
        {
            // Zoek de gebruiker met het opgegeven ID
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
        /// Haalt alle gebruikers op uit de database.
        /// </summary>
        /// <returns>Lijst van <see cref="Gebruiker"/> objecten.</returns>
        public List<Gebruiker> GetGebruikers()
        {
            var gebruikerlijst = new List<Gebruiker>();
            // Maak verbinding met de database en voer een SELECT-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("select * from tblgebruiker", connection);
                using (var reader = command.ExecuteReader())
                {
                    // Lees alle rijen uit de resultset en maak Gebruiker-objecten aan
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

        /// <summary>
        /// Haalt een boek op uit de database op basis van zijn ID.
        /// </summary>
        /// <param name="boekenId">Het unieke ID van het boek.</param>
        /// <returns>Het <see cref="Boek"/> object indien gevonden, anders null.</returns>
        public Boek GetBoekById(int boekenId)
        {
            // Zoek het boek met het opgegeven ID
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM tblboeken WHERE BoekenId = @boekenId", connection);
                command.Parameters.AddWithValue("@boekenId", boekenId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Boek
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
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Haalt alle leningen op uit de database.
        /// </summary>
        /// <returns>Lijst van <see cref="Lening"/> objecten.</returns>
        public List<Lening> getleningen()
        {
            var list = new List<Lening>();
            // Maak verbinding met de database en voer een SELECT-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("SELECT * FROM tblleningen", connection);
                using (var reader = command.ExecuteReader())
                {
                    // Lees alle rijen uit de resultset en maak Lening-objecten aan
                    while (reader.Read())
                    {
                        var lening = new Lening
                        {
                            LeningId = Convert.ToInt32(reader["LeningId"]),
                            Startdatum = DateOnly.FromDateTime(Convert.ToDateTime(reader["DatumUitlening"])),
                            Einddatum = DateOnly.FromDateTime(Convert.ToDateTime(reader["DatumTerug"]))
                        };
                        list.Add(lening);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// Voegt een nieuwe lening toe aan de database.
        /// </summary>
        /// <param name="DatumUitlening">De datum waarop het boek is uitgeleend.</param>
        /// <param name="DatumTerug">De datum waarop het boek teruggebracht moet worden.</param>
        public void InsertLening(DateOnly DatumUitlening, DateOnly DatumTerug)
        {
            // Maak verbinding met de database en voer een INSERT-query uit
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO tblleningen (DatumUitlening, DatumTerug) VALUES (@datumuitlening, @datumterug)", connection);
                command.Parameters.AddWithValue("@datumuitlening", DatumUitlening);
                command.Parameters.AddWithValue("@datumterug", DatumTerug);
                command.ExecuteNonQuery();
            }
        }
    }
}
