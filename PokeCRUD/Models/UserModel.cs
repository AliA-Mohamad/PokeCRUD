using Npgsql;
using PokeCRUD.Services;

namespace PokeCRUD.Models;

public class UserModel
{
    public NpgsqlConnection connection;

    public UserModel(string key)
    {
        PokeSQLService.TestarBanco(key);
        connection = new NpgsqlConnection(key);
    }

    public void RegistrarUsuario(string email, string nome, string senha)
    {
        try
        {
            using (connection)
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (Email, Nome, Senha) VALUES (@Email, @Nome, @Senha)";

                NpgsqlCommand command = new(insertQuery, connection);
                command.Parameters.AddWithValue("Email", email);
                command.Parameters.AddWithValue("Nome", nome);
                command.Parameters.AddWithValue("Senha", senha);

                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            throw new ApplicationException(ex.Message);
        }
    }

    public int LogarUsuario(string email, string senha)
    {
        try
        {
            using (connection)
            {
                connection.Open();

                string userQuery = "SELECT id FROM Users WHERE Email = @Email AND Senha = @Senha";

                NpgsqlCommand command = new(userQuery, connection);

                command.Parameters.AddWithValue("Email", email);
                command.Parameters.AddWithValue("Senha", senha);

                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    return id;
                }
            }
        }
        catch
        {
            throw new ApplicationException("Credenciais invalidas.");
        }

        throw new ApplicationException("Erro ao acessar banco");
    }

    //O Erro esta aqui :D
    public string GetNameById(int id)
    {
        try
        {
            using (connection)
            {
                connection.Open();

                string userQuery = "SELECT Nome FROM Users WHERE Id = @Id";

                NpgsqlCommand command = new(userQuery, connection);

                command.Parameters.AddWithValue("Id", id);

                NpgsqlDataReader reader = command.ExecuteReader();

                return reader.GetString(0);
            }
        }
        catch
        {
            throw new ApplicationException("Erro ao acessar banco(aqui)");
        }
    }

}
