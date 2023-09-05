using PokeCRUD.Services;
using PokeCRUD.Models;
using PokeCRUD.Forms;
using Newtonsoft.Json.Linq;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private PokeSQLService? pokeService;

    public MainForm()
    {
        InitializeComponent();

        try
        {
            PokeSQLService pokeService = new("Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;");
            this.pokeService = pokeService;
        }
        catch (Exception e)
        {
            ErroForm form = new(e.Message);
            form.ShowDialog();
        }
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new();
        form.ShowDialog();
    }
}