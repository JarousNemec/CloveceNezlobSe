namespace BroNezlobSe;

public class Figurine
{
    private Brush _brush;
    
    private static Pen pen = new (Color.Black, 3);
    public Color Color;
    public int Number;
    public Figurine(Color color, int number)
    {
        Number = number;
        Color = color;
        _brush = new SolidBrush(color);
    }

    public void Paint(Graphics g, Point pos)
    {
        int width = 30;
        int height = 45;
        int xPos = (StandingTile.TileSize - width) / 2 + pos.X;
        
        var triangle = new[]
        {
            new Point(xPos + width / 2, pos.Y + width / 2), new Point(xPos, pos.Y + height),
            new Point(xPos + width, pos.Y + height)
        };
        g.FillPolygon(_brush,triangle);
        g.DrawPolygon(pen, triangle);
        int headSize = (int)(width / 1.3);
        g.FillEllipse(_brush, xPos+ (width-headSize)/2, pos.Y, headSize, headSize);
        g.DrawEllipse(pen, xPos+ (width-headSize)/2, pos.Y, headSize, headSize);
        g.DrawString(Number.ToString(), new Font(FontFamily.GenericSansSerif, 12), new SolidBrush(Color.Goldenrod), (int)(xPos+width/3.5), (int)(pos.Y+width/1.2));
    }
}