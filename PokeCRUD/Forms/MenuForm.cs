using PokeCRUD.Models;
using PokeCRUD.Services;
using System.Net;

namespace PokeCRUD.Forms;

public partial class MenuForm : Form
{
    int _id;
    UserModel _db;


    public MenuForm(int id, UserModel db)
    {
        InitializeComponent();
        _db = db;
        _id = id;
        labelNome.Text = _db.GetNameById(id);
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

    private void labelNomePokemon_Click(object sender, EventArgs e)
    {

    }
}
