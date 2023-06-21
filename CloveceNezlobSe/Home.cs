namespace BroNezlobSe;

public class Home
{
    public readonly int HomeIndex;
    public readonly List<StandingTile> HomeTiles;
    public readonly Color Color;
    public Home(int homeIndex, List<StandingTile> tiles)
    {
        HomeIndex = homeIndex;
        HomeTiles = tiles;
        Color = HomeTiles[0].Color;
        for (int i = 0; i < HomeTiles.Count; i++)
        {
            HomeTiles[i].StandingFigurine = new Figurine(Color, i+1);
        }
    }

    public void Paint(Graphics g)
    {
        foreach (var tile in HomeTiles)
        {
            tile.Paint(g);
        }
    }

    public int DeployFigurine()
    {
        for (int i = 0; i < HomeTiles.Count; i++)
        {
            if (HomeTiles[i].StandingFigurine != null)
            {
                int number = HomeTiles[i].StandingFigurine.Number;
                HomeTiles[i].StandingFigurine = null;
                return number;
            } 
        }

        return 0;
    }

    public void AccomodateFigurine(int number)
    {
        for (int i = 0; i < HomeTiles.Count; i++)
        {
            if (HomeTiles[i].StandingFigurine == null)
            {
                HomeTiles[i].StandingFigurine = new Figurine(Color, number);
                return;
            } 
        }
    }
    
}