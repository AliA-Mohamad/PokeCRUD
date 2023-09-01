using PokeCRUD.Services;
using PokeCRUD.Models;

namespace PokeCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void Gerar_Click(object sender, EventArgs e)
        {
            PokeData pokemonData = await PokeAPIService.GetRandomPokemon();
            label2.Text = pokemonData.Name;
            testeSQL.inicia();
        }
    }
}