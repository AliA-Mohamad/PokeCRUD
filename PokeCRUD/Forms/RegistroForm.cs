using PokeCRUD.Models;

namespace PokeCRUD.Forms;

public partial class RegistroForm : Form
{
    private UserModel _db;

    public RegistroForm(UserModel db)
    {
        InitializeComponent();
        _db = db;
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        _db.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
        this.Close();
    }
}
