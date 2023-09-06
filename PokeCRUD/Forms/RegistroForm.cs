using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD.Forms;

public partial class RegistroForm : Form
{
    private PokeSQLService? _pokeSQLService;

    public RegistroForm(PokeSQLService pokeSQLService)
    {
        InitializeComponent();
        _pokeSQLService = pokeSQLService;
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        UsersModel db = new(_pokeSQLService!);

        try
        {
            db.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
            Close();
        }
        catch (Exception ex)
        {
            ErroForm form = new(ex.Message);
            form.ShowDialog();
        }
    }
}
