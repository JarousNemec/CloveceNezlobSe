namespace BroNezlobSe;

public class ThrowsManager
{
    private List<Home> _homes;
    private List<Finish> _finishes;
    private StandingTile[] _map;
    public static Color[] PlaysOrder = { Color.Yellow, Color.Green, Color.Blue, Color.Red };
    public List<int>[] DeployedFigurines;
    public int ActualPlayerId = 0;
    private int ActualThrow = 0;
    private int LastPlayerId = 3;

    public ThrowsManager(List<Home> homes, List<Finish> finishes, StandingTile[] map)
    {
        DeployedFigurines = new List<int>[4];
        for (int i = 0; i < DeployedFigurines.Length; i++)
        {
            DeployedFigurines[i] = new List<int>();
        }

        _homes = homes;
        _finishes = finishes;
        _map = map;
    }

    public delegate void UpdateDispatcher();

    public event UpdateDispatcher? OnUpdate;

    public void MakeAction(int throwNumber)
    {
        ActualThrow = throwNumber;
        var actionsDialog = new ActionForm();
        actionsDialog.OnActionChosed += OnActionChosed;
        actionsDialog.SetInfo(PlaysOrder[ActualPlayerId].Name, throwNumber,
            DeployedFigurines[ActualPlayerId].Contains(1), DeployedFigurines[ActualPlayerId].Contains(2),
            DeployedFigurines[ActualPlayerId].Contains(3), DeployedFigurines[ActualPlayerId].Contains(4),
            throwNumber == 6);
        actionsDialog.Show();
        LastPlayerId = ActualPlayerId;
        if (ActualPlayerId < 3)
        {
            ActualPlayerId++;
        }
        else
        {
            ActualPlayerId = 0;
        }
    }

    private void OnActionChosed(Actions action)
    {
        switch (action)
        {
            case Actions.MoveN1:
                MoveFigurine(1, PlaysOrder[LastPlayerId]);
                break;
            case Actions.MoveN2:
                MoveFigurine(2, PlaysOrder[LastPlayerId]);
                break;
            case Actions.MoveN3:
                MoveFigurine(3, PlaysOrder[LastPlayerId]);
                break;
            case Actions.MoveN4:
                MoveFigurine(4, PlaysOrder[LastPlayerId]);
                break;
            case Actions.Deploy:
                DeployFigurine();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(action), action, null);
        }

        OnUpdate?.Invoke();
    }

    private void DeployFigurine()
    {
        var home = _homes.Find(x => x.Color == PlaysOrder[LastPlayerId]);
        var number = home.DeployFigurine();
        if(number < 1 || number > 4)return;
        DeployedFigurines[LastPlayerId].Add(number);
        PlaceFigurine(home.HomeIndex, home.Color, number);
    }

    private void MoveFigurine(int number, Color color)
    {
        for (int i = 0; i < _map.Length; i++)
        {
            if (_map[i].StandingFigurine == null)
                continue;
            if (_map[i].StandingFigurine.Number == number && _map[i].StandingFigurine.Color == color)
            {
                int futurePos = i + ActualThrow;
                if (futurePos > 31) futurePos -= 32;

                if (EnteringHome(i, futurePos, number, color, out int rest))
                {
                    var finish = _finishes.Find(x => x.Color == color);
                    if (rest == 4 - finish.AccommodatedCount)
                    {
                        finish.FinishTiles[finish.FinishTiles.Length - 1 - finish.AccommodatedCount].StandingFigurine =
                            new Figurine(color, number);
                        DeployedFigurines[Array.IndexOf(PlaysOrder, finish.Color)].Remove(number);
                        finish.AccommodatedCount++;
                        CheckVictory(color, finish);
                        return;
                    }

                    return;
                }

                PlaceFigurine(futurePos, color, number);
                _map[i].StandingFigurine = null;
                return;
            }
        }
    }

    private static void CheckVictory(Color color, Finish finish)
    {
        if (finish.AccommodatedCount == 4)
        {
            MessageBox.Show($"Hru vyhrál hráč s barvou {color}");
        }
    }

    private bool EnteringHome(int i, int futurePos, int number, Color color, out int rest)
    {
        var home = _homes.Find(x => x.Color == color);
        var homeIndex = home.HomeIndex;
        if ((i < homeIndex && futurePos > homeIndex) ||
            (i == homeIndex && _map[homeIndex].PassedFigurines.Contains(number + 10)))
        {
            rest = futurePos - homeIndex;
            return true;
        }

        rest = 0;
        return false;
    }

    private void PlaceFigurine(int futurePos, Color color, int number)
    {
        if (_map[futurePos].StandingFigurine == null)
            _map[futurePos].StandingFigurine = new Figurine(color, number);
        else
        {
            var home = _homes.Find(x => x.Color == _map[futurePos].StandingFigurine.Color);
            home?.AccomodateFigurine(_map[futurePos].StandingFigurine.Number);
            if (home != null && _map[home.HomeIndex].PassedFigurines.Contains(_map[futurePos].StandingFigurine.Number))
                _map[home.HomeIndex].PassedFigurines.Remove(_map[futurePos].StandingFigurine.Number);
            DeployedFigurines[Array.IndexOf(PlaysOrder, home.Color)].Remove(_map[futurePos].StandingFigurine.Number);
            _map[futurePos].StandingFigurine = new Figurine(color, number);
        }
    }
}