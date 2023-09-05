using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD.Forms;

public partial class RegistroForm : Form
{
    private PokeSQLService? pokeSQLService;

    public RegistroForm(PokeSQLService pokeSQLService)
    {
        InitializeComponent();
        this.pokeSQLService = pokeSQLService;
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        UsersModel db = new(pokeSQLService!);
        db.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
    }
}
