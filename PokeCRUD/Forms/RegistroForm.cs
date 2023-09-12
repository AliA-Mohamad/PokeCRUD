using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD.Forms;

public partial class RegistroForm : Form
{
    private PokeSQLService _pokeSQLService;

    public RegistroForm(PokeSQLService pokeSQLService)
    {
        _pokeSQLService = pokeSQLService;
        InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        UserModel db = new(_pokeSQLService.key);
        db.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
        this.Close();
    }
}
