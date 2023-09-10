using Npgsql;

namespace PokeCRUD.Models;

public class UserModelTeste
{
    public NpgsqlConnection connection;

    public UserModelTeste(string key)
    {
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
}
