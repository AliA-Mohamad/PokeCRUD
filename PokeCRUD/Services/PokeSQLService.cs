using Npgsql;

namespace PokeCRUD.Services;

public class PokeSQLService
{
    public string key { get; }

    public PokeSQLService(string key)
    {
        this.key = key;

        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(key))
            {
                connection.Open();
            }
        }
        catch
        {
            throw new ApplicationException("Erro no banco de dados");
        }
    }
}
