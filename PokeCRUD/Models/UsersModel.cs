using Npgsql;
using PokeCRUD.Services;

namespace PokeCRUD.Models;

internal class UsersModel
{
    private PokeSQLService pokeSQLService;

    public UsersModel(PokeSQLService pokeSQLService)
    {
        this.pokeSQLService = pokeSQLService;
    }

    public void RegistrarUsuario(string email, string nome, string senha)
    {
        using (NpgsqlConnection connection = new(pokeSQLService.connectionString))
        {
            connection.Open();

            string insertQuery = "INSERT INTO Users (Email, Nome, Senha) VALUES (@Email, @Nome, @Senha)";
            using(NpgsqlCommand command =  new(insertQuery, connection))
            {
                command.Parameters.AddWithValue("Email", email);
                command.Parameters.AddWithValue("Nome", nome);
                command.Parameters.AddWithValue("Senha", senha);
                command.ExecuteNonQuery();
            }
        }
    }
}
