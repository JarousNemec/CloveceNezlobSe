namespace BroNezlobSe;

public class Finish
{
    private readonly int EnterTileIndex;
    public readonly StandingTile[] FinishTiles;
    public int AccommodatedCount { get; set; } = 0;
    public Color Color { get; set; }
    public Finish(int enterTileIndex, StandingTile[] tiles)
    {
        EnterTileIndex = enterTileIndex;
        FinishTiles = tiles;
        Color = tiles[0].Color;
    }

    public void Paint(Graphics g)
    {
        foreach (var tile in FinishTiles)
        {
            tile.Paint(g);
        }
    }
}