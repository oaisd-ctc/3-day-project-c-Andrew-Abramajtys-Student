namespace HideNSeek;
public class Hider
{
    private int spotChoice;
    public Hider()
    {
        this.spotChoice = spotChoice;
    }
    public void ResetSpot()
    {
        Random random = new Random();
        int rand1 = random.Next(1, 8);
        int randNumber = rand1;
        spotChoice = randNumber;
    }
    public void TestRandom()
    {
        Console.WriteLine("Hider is in spot " + spotChoice);
    }
}