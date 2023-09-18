using PokeCRUD.Models;
using PokeCRUD.Services;
using System.Net;

namespace PokeCRUD.Forms;

public partial class MenuForm : Form
{
    int _id;
    PokeData poke;
    PokeSQLService _pokeSQLService;
    UserModel dbUser;
    DexModel dbDex;

    public MenuForm(int id, PokeSQLService pokeSQLService)
    {
        InitializeComponent();

        _pokeSQLService = pokeSQLService;
        _id = id;
        dbDex = new(_id, _pokeSQLService);
        dbUser = new(_pokeSQLService);

        labelNome.Text = dbUser.GetNameById(_id);

    }

    private async void btnProcurar_Click(object sender, EventArgs e)
    {
        poke = await PokeAPIService.GetRandomPokemon();
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

    private void Adicionar_Click(object sender, EventArgs e)
    {
        if(labelNomePokemon.Text == "N/A")
        {
            MessageBox.Show("Nenhum pokemon encontrado. Porfavor procure por um antes de registra-lo");
        }
        else
        {
            try
            {
                dbDex.InsertPokemon(poke);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
