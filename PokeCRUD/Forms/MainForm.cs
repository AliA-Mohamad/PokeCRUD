using PokeCRUD.Services;
using PokeCRUD.Forms;
using PokeCRUD.Models;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private PokeSQLService _pokeSQLService;

    public MainForm()
    {
        InitializeComponent();
        try
        {
            PokeSQLService pokeSQLService = new("Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;");
            _pokeSQLService = pokeSQLService;
        }
        catch (Exception e)
        {
            ErroForm form = new(e.Message);
            form.ShowDialog();
        }
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new(_pokeSQLService!);
        form.ShowDialog();
    }

    private void btnLogar_Click(object sender, EventArgs e)
    {
        try
        {
            UsersModel userModel = new(_pokeSQLService!);
            int id = userModel.LogarUsuario(emailText.Text, senhaText.Text);
        }
        catch(Exception ex)
        {
            ErroForm form = new(ex.Message);
            form.ShowDialog();
        }
    }
}