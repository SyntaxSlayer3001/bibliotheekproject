using Domain_bib.Business;
using MySql.Data.MySqlClient;

namespace Domain_bib.Persistence
{
    public class Boekmapper
    {
        private readonly string _connectionString;

        public Boekmapper()
        {
            _connectionString = "server=localhost;user=root;database=eindprojectbibliotheek;port=3306;password=1234";
        }
        public void InsertBoek(string titel, int GenreId, string auteur, string uitgever, string taal, int graad, string isbn)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = new MySqlCommand("INSERT INTO tblboeken (Titel, GenreId, Auteur, Uitgever, Taal, Graad, ISBN) VALUES (@titel, @genreId, @auteur, @uitgever, @taal, @graad, @isbn)", connection);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@genreId", GenreId);
                command.Parameters.AddWithValue("@auteur", auteur);
                command.Parameters.AddWithValue("@uitgever", uitgever);
                command.Parameters.AddWithValue("@taal", taal);
                command.Parameters.AddWithValue("@graad", graad);
                command.Parameters.AddWithValue("@isbn", isbn);
                command.ExecuteNonQuery();
            }
        }
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

        public void UpdateBoek(int boekenId, string titel, int genreId, string auteur, string uitgever, string taal, int graad, string isbn)
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
    }
}
