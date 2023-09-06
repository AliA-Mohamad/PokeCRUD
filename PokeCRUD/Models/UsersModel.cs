using Npgsql;
using PokeCRUD.Services;

namespace PokeCRUD.Models;

internal class UsersModel
{
    private PokeSQLService pokeSQLService;
    private string? idUsuario;

    public UsersModel(PokeSQLService pokeSQLService)
    {
        this.pokeSQLService = pokeSQLService;
    }

    public void RegistrarUsuario(string email, string nome, string senha)
    {
        try
        {
            using (NpgsqlConnection connection = new(pokeSQLService.connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Users (Email, Nome, Senha) VALUES (@Email, @Nome, @Senha)";

                using (NpgsqlCommand command = new(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("Email", email);
                    command.Parameters.AddWithValue("Nome", nome);
                    command.Parameters.AddWithValue("Senha", senha);
                    command.ExecuteNonQuery();
                }
            }
        }
        catch(Exception ex)
        {
            throw new ApplicationException(ex.Message);
        }
    }

    public int LogarUsuario(string email, string senha)
    {
        try 
        {
            using (NpgsqlConnection connection = new(pokeSQLService.connectionString))
            {
                connection.Open();

                string userQuery = "SELECT * FROM Users WHERE Email = @Email AND Senha = @Senha";

                using (NpgsqlCommand command = new(userQuery, connection))
                {
                    command.Parameters.AddWithValue("Email", email);
                    command.Parameters.AddWithValue("Senha", senha);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            return id;
                        }
                    }
                }
            }
        }
        catch
        {
            throw new ApplicationException("Credenciais invalidas.");
        }
        throw new ApplicationException("Credenciais invalidas.");
    }
}
