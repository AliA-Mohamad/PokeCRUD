using PokeCRUD.Services;
using PokeCRUD.Models;

namespace PokeCRUD
{
    public partial class MainForm : Form
    {
        string connectionString = "Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;";
        PokeData pokeData;

        public MainForm()
        {
            InitializeComponent();
        }

        private async void Gerar_Click(object sender, EventArgs e)
        {
            pokeData = await PokeAPIService.GetRandomPokemon();
            label2.Text = pokeData.Name;

            PokeSQLService pokeService = new(connectionString);
            pokeService.AdicionarPokemon(pokeData);
        }

        private void adicionar_Click(object sender, EventArgs e)
        {
            PokeSQLService pokeService = new(connectionString);
            pokeService.AdicionarPokemon(pokeData);
        }
    }
}