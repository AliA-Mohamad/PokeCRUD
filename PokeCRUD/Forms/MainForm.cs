using PokeCRUD.Forms;
using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private PokeSQLService _pokeSQLService;

    public MainForm(PokeSQLService pokeSQLService)
    {
        InitializeComponent();
        _pokeSQLService = pokeSQLService;
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new(_pokeSQLService);
        form.ShowDialog();
    }

    private void btnLogar_Click(object sender, EventArgs e)
    {
        try
        {
            UserModel db = new(_pokeSQLService.key);
            int id = db.LogarUsuario(emailText.Text, senhaText.Text);

            MenuForm form = new(id, _pokeSQLService);

            form.Show();
            Hide();
        }
        catch(Exception ex)
        {
            ErroForm form = new(ex.Message);
            form.ShowDialog();
        }
    }
}