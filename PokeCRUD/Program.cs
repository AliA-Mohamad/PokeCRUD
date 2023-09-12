using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            PokeSQLService pokeSQLService = new("Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(pokeSQLService));
        }
    }
}