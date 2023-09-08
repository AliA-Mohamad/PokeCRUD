using Npgsql;
using PokeCRUD.Services;
using System.Data;

namespace PokeCRUD.Models;

public class UsersModel
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

                string userQuery = "SELECT id FROM Users WHERE Email = @Email AND Senha = @Senha";

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

    public string GetNameById(int id)
    {
        try
        {
            using (NpgsqlConnection connection = new(pokeSQLService.connectionString))
            {
                connection.Open();

                string userQuery = "SELECT Nome FROM Users WHERE Id = @Id";

                using (NpgsqlCommand command = new(userQuery, connection))
                {
                    command.Parameters.AddWithValue("Id", id);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nome = reader.GetString(0);
                            return nome;
                        }
                        else
                        {
                            throw new ApplicationException("Erro ao acessar banco");
                        }
                    }
                }
            }
        }
        catch
        {
            throw new ApplicationException("Erro ao acessar banco");
        }
    }
}
