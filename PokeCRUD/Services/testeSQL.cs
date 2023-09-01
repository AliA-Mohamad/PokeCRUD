using System.Configuration;
using System.Data.SqlClient;
using Npgsql;

namespace PokeCRUD.Services
{
    internal class testeSQL
    {
        public static void inicia()
        {
            string connectionString = "Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                int idPokemon = 123;
                string nomePokemon = "Bulbasaur";
                string insertQuery = "INSERT INTO pokedex (Nome) VALUES (@Nome)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("Nome", nomePokemon);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }
    }
}
