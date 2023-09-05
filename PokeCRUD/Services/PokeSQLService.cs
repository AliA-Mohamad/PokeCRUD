using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using PokeCRUD.Models;

namespace PokeCRUD.Services;

internal class PokeSQLService
{
    private string _connectionString;

    public PokeSQLService(string connectionString)
    {
        _connectionString = connectionString;

        try
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
            }
        }
        catch
        {
            throw new ApplicationException("Não foi possível estabelecer uma conexão com o banco de dados.");
        }
    }

    public void AdicionarPokemon(PokeData novoPokemon)
    {
        using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO pokedex (Nome) VALUES (@Nome)";

            using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("Nome", novoPokemon.Name);
                int rowsAffected = command.ExecuteNonQuery();
            }
        }
    }
}
