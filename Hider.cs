namespace HideNSeek;
public class Hider
{
    private int spotChoice;
    public Hider()
    {
        this.spotChoice = 0;
    }
    public void ResetSpot()
    {
        var random = new System.Random();
        spotChoice = random.Next(0, 7);
    }
    public void TestRandom()
    {
        Console.WriteLine("Hider is in spot " + spotChoice);
    }

    public int GetSpotChoice()
    {
        return spotChoice;
    }
}