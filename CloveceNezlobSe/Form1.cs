namespace BroNezlobSe;

public partial class Form1 : Form
{
    private GameManager _manager;
    public Form1()
    {
        InitializeComponent();
        _manager = new GameManager(this);
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
        _manager.Paint(e.Graphics);
    }

    private void _btnThrow_Click(object sender, EventArgs e)
    {
        _manager.Throw();
    }
}