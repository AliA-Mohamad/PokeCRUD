namespace PokeCRUD.Forms;

public partial class ErroForm : Form
{
    public ErroForm(string erroMsg)
    {
        InitializeComponent();
        textErro.Text = erroMsg;
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
