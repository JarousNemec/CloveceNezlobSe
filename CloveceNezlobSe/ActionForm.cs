using System.Windows.Forms;

namespace BroNezlobSe;

public partial class ActionForm : Form
{
    public ActionForm()
    {
        InitializeComponent();
    }

    public void SetInfo(string color, int number, bool enableN1, bool enableN2, bool enableN3, bool enableN4,
        bool enableDeploy)
    {
        _lblPlayerColor.Text = color;
        _lblThrowNumber.Text = number.ToString();
        _btnDeployFigurine.Enabled = enableDeploy;
        _btnMoveN1.Enabled = enableN1;
        _btnMoveN2.Enabled = enableN2;
        _btnMoveN3.Enabled = enableN3;
        _btnMoveN4.Enabled = enableN4;
    }

    public delegate void ActionChosedDispatcher(Actions action);

    public ActionChosedDispatcher? OnActionChosed;

    private void _btnMoveN1_Click(object sender, EventArgs e)
    {
        OnActionChosed?.Invoke(Actions.MoveN1);
        Close();
    }

    private void _btnMoveN2_Click(object sender, EventArgs e)
    {
        OnActionChosed?.Invoke(Actions.MoveN2);
        Close();
    }

    private void _btnMoveN3_Click(object sender, EventArgs e)
    {
        OnActionChosed?.Invoke(Actions.MoveN3);
        Close();
    }

    private void _btnMoveN4_Click(object sender, EventArgs e)
    {
        OnActionChosed?.Invoke(Actions.MoveN4);
        Close();
    }

    private void _btnDeployFigurine_Click(object sender, EventArgs e)
    {
        OnActionChosed?.Invoke(Actions.Deploy);
        Close();
    }
}