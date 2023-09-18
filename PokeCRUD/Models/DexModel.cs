using Npgsql;
using PokeCRUD.Services;

namespace PokeCRUD.Models;

internal class DexModel
{
    private PokeSQLService pokeSQLService;
    private int id;

    public DexModel(int id, PokeSQLService pokeSQLService)
    {
        this.pokeSQLService = pokeSQLService;
        this.id = id;
    }

    public void InsertPokemon(PokeData poke)
    {
        if (VerificaSeTem(poke))
        {
            throw new ApplicationException("Pokemon ja adicionado.");
        }

        try
        {
            using (NpgsqlConnection connection = new(pokeSQLService.key))
            {
                connection.Open();

                string data = "INSERT INTO Pokedex (Dono, Pokemon, Nome) VALUES (@Dono, @Pokemon, @Nome)";

                NpgsqlCommand command = new(data, connection);

                command.Parameters.AddWithValue("Dono", id);
                command.Parameters.AddWithValue("Pokemon", poke.Id);
                command.Parameters.AddWithValue("Nome", poke.Name);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException(ex.Message);
        }
    }

    private bool VerificaSeTem(PokeData poke)
    {
        using (NpgsqlConnection connection = new(pokeSQLService.key))
        {
            connection.Open();

            string data = "SELECT Pokemon FROM Pokedex WHERE Pokemon = @Pokemon";

            NpgsqlCommand command = new(data, connection);

            command.Parameters.AddWithValue("Pokemon", poke.Id.ToString());

            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}