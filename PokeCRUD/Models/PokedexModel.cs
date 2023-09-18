using Npgsql;

namespace PokeCRUD.Models;

internal class PokedexModel
{
    private string _connectionString;

    public PokedexModel(string connectionString)
    {
        _connectionString = connectionString;
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
