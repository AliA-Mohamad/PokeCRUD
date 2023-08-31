using PokeCRUD.Services;

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
            PokeData pokemonData = await PokeAPIService.PokemonAPIConection();
            label2.Text = pokemonData.name;
        }
    }
}