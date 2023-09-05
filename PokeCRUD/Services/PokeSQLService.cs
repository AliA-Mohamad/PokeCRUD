using Npgsql;

namespace PokeCRUD.Services;

public class PokeSQLService
{
    public string connectionString { get; }

    public PokeSQLService(string connectionString)
    {
        this.connectionString = connectionString;

        try
        {
            using(NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
            }
        }
        catch
        {
            throw new ApplicationException("Não foi possível estabelecer uma conexão com o banco de dados.");
        }
    }
}
