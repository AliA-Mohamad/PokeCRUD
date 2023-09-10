using Npgsql;

namespace PokeCRUD.Services;

public class PokeSQLService
{
    public static void TestarBanco(string connectionString)
    {
        try
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
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
