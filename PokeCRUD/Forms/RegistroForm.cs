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
        UserModelTeste db = new("Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;");
        db.RegistrarUsuario(textEmail.Text, textNome.Text, textSenha.Text);
        this.Close();
    }
}
