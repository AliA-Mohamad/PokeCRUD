using Npgsql;
using PokeCRUD.Services;

namespace PokeCRUD.Models;

public class UserModel
{
    public string _key;

    public UserModel(string key)
    {
        _key = key;
    }

    public void RegistrarUsuario(string email, string nome, string senha)
    {
        try
        {
            using (NpgsqlConnection connection  = new(_key))
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
            using (NpgsqlConnection connection = new(_key))
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

        throw new ApplicationException("Credenciais invalidas.");
    }

    public string GetNameById(int id)
    {
        try
        {
            using (NpgsqlConnection connection = new(_key))
            {
                connection.Open();

                string userQuery = "SELECT Nome FROM Users WHERE Id = @Id";

                using (NpgsqlCommand command = new(userQuery, connection))
                {
                    command.Parameters.AddWithValue("Id", 8);

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
