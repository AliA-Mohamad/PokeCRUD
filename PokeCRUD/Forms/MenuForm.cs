using PokeCRUD.Models;
using PokeCRUD.Services;
using System.Net;

namespace PokeCRUD.Forms;

public partial class MenuForm : Form
{
    int _id;
    PokeSQLService _pokeSQLService;
    UserModel dbUser;

    public MenuForm(int id, PokeSQLService pokeSQLService)
    {
        _pokeSQLService = pokeSQLService;
        _id = id;
        dbUser = new(_pokeSQLService.key);

        

        InitializeComponent();
        labelNome.Text = "asd";
    }

    private async void btnProcurar_Click(object sender, EventArgs e)
    {
        PokeData poke = await PokeAPIService.GetRandomPokemon();
        labelNomePokemon.Text = poke.Name;

        try
        {
            using (WebClient webClient = new())
            {
                byte[] data = webClient.DownloadData(poke.sprites.front_default);
                using (MemoryStream stream = new(data))
                {
                    pictureBoxPokemon.Image = Image.FromStream(stream);
                }
            }
        }
        catch
        {
            MessageBox.Show("Api deu ruim");
        }
    }

}
