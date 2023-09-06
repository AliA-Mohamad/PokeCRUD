using Microsoft.VisualBasic;
using PokeCRUD.Models;
using PokeCRUD.Services;
using System.Net;

namespace PokeCRUD.Forms;

public partial class MenuForm : Form
{
    public MenuForm(int id)
    {
        InitializeComponent();
        labelNome.Text = id.ToString();
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
