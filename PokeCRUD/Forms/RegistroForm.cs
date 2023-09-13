using PokeCRUD.Models;
using PokeCRUD.Services;

namespace PokeCRUD.Forms;

public partial class RegistroForm : Form
{
    private UserModel _userDB;

    public RegistroForm(UserModel userDB)
    {
        _userDB = userDB;
        InitializeComponent();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        _userDB.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
        this.Close();
    }
}
