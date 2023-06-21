namespace BroNezlobSe;

public static class Dice
{
    private static Random _r;

    static Dice()
    {
        _r = new Random();
    }
    public static int GetThrowNumber()
    {
        return _r.Next(1,7);
    }
}