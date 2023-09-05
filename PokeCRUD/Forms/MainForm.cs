using PokeCRUD.Services;
using PokeCRUD.Forms;

namespace PokeCRUD;

public partial class MainForm : Form
{
    private PokeSQLService? pokeSQLService;

    public MainForm()
    {
        InitializeComponent();
        try
        {
            PokeSQLService pokeSQLService = new("Server=motty.db.elephantsql.com;Database=fqsjuokr;User Id=fqsjuokr;Password=2CziZP6HbfASrTYOn_61MUCyTh_B6aqA;");
            this.pokeSQLService = pokeSQLService;
        }
        catch (Exception e)
        {
            ErroForm form = new(e.Message);
            form.ShowDialog();
        }
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        RegistroForm form = new(pokeSQLService!);
        form.ShowDialog();
    }
}