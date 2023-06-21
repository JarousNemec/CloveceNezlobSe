namespace BroNezlobSe;

public class StandingTile
{
    public Point DrawingPos;
    private bool IsHome { get; set; }
    public static int TileSize = 50;
    public List<int> PassedFigurines;

    public Figurine StandingFigurine
    {
        get => _standingFigurine;
        set
        {
            _standingFigurine = value;
            if(value == null)
                return;
            if(PassedFigurines.Contains(_standingFigurine.Number))
                PassedFigurines.Add(_standingFigurine.Number+10);
            if (IsHome && _standingFigurine.Color == Color)
                PassedFigurines.Add(_standingFigurine.Number);
        }
    }
    private Figurine _standingFigurine;

    public Brush Brush { get; set; }
    public Color Color;

    public StandingTile(bool isHome, Color color, Point drawingPos)
    {
        PassedFigurines = new List<int>();
        Color = color;
        IsHome = isHome;
        Brush = new SolidBrush(color);
        DrawingPos = drawingPos;
    }

    public void Paint(Graphics g)
    {
        g.FillEllipse(Brush, DrawingPos.X, DrawingPos.Y, TileSize, TileSize);
        if (StandingFigurine != null)
        {
            StandingFigurine.Paint(g, DrawingPos);
        }
    }
}