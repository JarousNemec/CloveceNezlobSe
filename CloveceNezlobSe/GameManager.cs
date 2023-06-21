namespace BroNezlobSe;

public class GameManager
{
    private StandingTile[] _map;

    private Home _redHome;
    private Home _blueHome;
    private Home _greenHome;
    private Home _yellowHome;

    private Finish _redFinish;
    private Finish _blueFinish;
    private Finish _greenFinish;
    private Finish _yellowFinish;

    private List<Home> _homes;
    private List<Finish> _finishes;

    private const int MapSize = 800;
    private const int TilesSpace = 20;

    private static readonly Point leftUpCorner = new(150, 150);
    private static readonly Point leftDownCorner = new(150, 650);
    private static readonly Point rightUpCorner = new(670, 150);
    private static readonly Point rightDownCorner = new(670, 650);
    
    private Color _commonTilesColor = Color.DimGray;

    private ThrowsManager _throwsManager;

    private Form _gameForm;
    public GameManager(Form gameForm)
    {
        _gameForm = gameForm;
        _map = new StandingTile[32];
        InitTilesPositions();
        _throwsManager = new ThrowsManager(_homes, _finishes, _map);
        _throwsManager.OnUpdate += () => { _gameForm.Invalidate(); };
    }

    private void InitTilesPositions()
    {
        int yStart = leftUpCorner.Y + TilesSpace + StandingTile.TileSize;
        int yEnd = leftDownCorner.Y;
        int ySpace = (yEnd - yStart) / 7;

        int xStart = leftUpCorner.X + TilesSpace + StandingTile.TileSize;
        int xEnd = rightUpCorner.X;
        int xSpace = (xEnd - xStart) / 7;


        _map[0] = (new StandingTile(false, Color.Yellow, leftUpCorner));
        for (int i = 1; i < 8; i++)
        {
            _map[i] = (new StandingTile(false, _commonTilesColor,
                new Point(leftUpCorner.X, leftUpCorner.Y + i * (ySpace))));
        }

        _map[8] = (new StandingTile(false, Color.Green, leftDownCorner));
        for (int i = 9; i < 16; i++)
        {
            _map[i] = (new StandingTile(false, _commonTilesColor,
                new Point(leftDownCorner.X + (i - 8) * xSpace, leftDownCorner.Y)));
        }

        _map[16] = (new StandingTile(false, Color.Blue, rightDownCorner));
        for (int i = 17; i < 24; i++)
        {
            _map[i] = (new StandingTile(false, _commonTilesColor,
                new Point(rightDownCorner.X, rightDownCorner.Y - (i - 16) * (ySpace))));
        }

        _map[24] = (new StandingTile(false, Color.Red, rightUpCorner));
        for (int i = 25; i < 32; i++)
        {
            _map[i] = (new StandingTile(false, _commonTilesColor,
                new Point(rightUpCorner.X - (i - 24) * xSpace, rightUpCorner.Y)));
        }

        _yellowHome = new Home(0, CreateHomeTiles(Color.Yellow, TilesSpace, TilesSpace));
        _redHome = new Home(8,
            CreateHomeTiles(Color.Green, TilesSpace, MapSize - TilesSpace - StandingTile.TileSize));
        _blueHome = new Home(16,
            CreateHomeTiles(Color.Blue, MapSize - TilesSpace - StandingTile.TileSize,
                MapSize - TilesSpace - StandingTile.TileSize));
        _greenHome = new Home(24,
            CreateHomeTiles(Color.Red, MapSize - TilesSpace - StandingTile.TileSize, TilesSpace));
        _yellowFinish = new Finish(0, CreateFinishTiles(Color.Yellow, 1, 1, xSpace, ySpace, leftUpCorner));
        _greenFinish = new Finish(8, CreateFinishTiles(Color.Green, 1, -1, xSpace, ySpace, leftDownCorner));
        _blueFinish = new Finish(16, CreateFinishTiles(Color.Blue, -1, -1, xSpace, ySpace, rightDownCorner));
        _redFinish = new Finish(24, CreateFinishTiles(Color.Red, -1, 1, xSpace, ySpace, rightUpCorner));

        _homes = new List<Home>() { _yellowHome, _greenHome, _blueHome, _redHome };
        _finishes = new List<Finish>() { _yellowFinish, _greenFinish, _blueFinish, _redFinish };
    }

    private List<StandingTile> CreateHomeTiles(Color color, int x, int y)
    {
        List<StandingTile> tiles = new List<StandingTile>();
        tiles.Add(new StandingTile(true, color, new Point(x, y)));
        tiles.Add(new StandingTile(true, color, new Point(x + TilesSpace + StandingTile.TileSize, y)));
        tiles.Add(new StandingTile(true, color,
            new Point(x + TilesSpace + StandingTile.TileSize, y + TilesSpace + StandingTile.TileSize)));
        tiles.Add(new StandingTile(true, color, new Point(x, y + TilesSpace + StandingTile.TileSize)));
        return tiles;
    }

    private StandingTile[] CreateFinishTiles(Color color, int xDir, int yDir, int xSpace, int ySpace,
        Point StartingPoint)
    {
        StandingTile[] tiles = new StandingTile[4];
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i] = new StandingTile(false, color,
                new Point((int)(StartingPoint.X + ((i + 1) * xDir * xSpace/1.3)), (int)(StartingPoint.Y + ((i + 1) * yDir * xSpace/1.3))));
        }

        return tiles;
    }

    public void Throw()
    {
        _throwsManager.MakeAction(Dice.GetThrowNumber());
    }

    public void Paint(Graphics g)
    {
        foreach (var tile in _map)
        {
            tile.Paint(g);
        }

        foreach (var home in _homes)
        {
            home.Paint(g);
        }

        foreach (var finish in _finishes)
        {
            finish.Paint(g);
        }
        // for (int i = 0; i < 32; i++)
        // {
        //     g.FillEllipse(Brushes.Pink, _moves[i]._drawingPos.X, _moves[i]._drawingPos.Y,60,60);
        //     Thread.Sleep(200);
        // }
    }
}