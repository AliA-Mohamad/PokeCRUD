using PokeCRUD.Forms;
using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private PokeSQLService _pokeSQLService;
    private UserModel dbUser;

    public MainForm(PokeSQLService pokeSQLService)
    {
        InitializeComponent();
        _pokeSQLService = pokeSQLService;
        dbUser = new UserModel(pokeSQLService);
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new(dbUser);
        form.ShowDialog();
    }

    private void btnLogar_Click(object sender, EventArgs e)
    {
        try
        {
            int id = dbUser.LogarUsuario(emailText.Text, senhaText.Text);

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