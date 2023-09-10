using PokeCRUD.Forms;
using PokeCRUD.Models;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private UserModel _userModel;

    public MainForm(UserModel userModel)
    {
        InitializeComponent();
        _userModel = userModel;
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new(_userModel);
        form.ShowDialog();
    }

    private void btnLogar_Click(object sender, EventArgs e)
    {
        try
        {
            int id = _userModel.LogarUsuario(emailText.Text, senhaText.Text);
            MenuForm form = new(id, _userModel);

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