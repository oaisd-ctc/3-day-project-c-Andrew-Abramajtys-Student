using HideNSeek;

public class Program
{
    public static int round = 0;
    public static int score = 0;

    public static void Main(string[] args)
    {
        StoryLine();
        Hider hider = new Hider();
        for (;;)
        {
            Spots spots = new Spots();
            RoundStart();
            Thread.Sleep(1000);
            Spots.HidingSpots();
            Thread.Sleep(1000);
            RoundEnd();
            Thread.Sleep(1000);
        }
    }

    public static void StoryLine()
    {
        Console.WriteLine("Your hanging out with your friend, and you decide to play hide and seek,");
        Console.WriteLine("but there's a catch you have 3 tries, if you are unable to find them in the 3 tries they win.");
        Thread.Sleep(1500);
    }

    public static void RoundStart()
    {
        round++;
        Console.WriteLine("Round: " + round);
        Console.WriteLine("Score: " + score);
    }

    public static void RoundEnd()
    {
        Console.WriteLine("Press enter to continue or say 'end' to quit.");
        string input = Console.ReadLine() ?? "";
        if (input == "end")
        {
            Environment.Exit(0);
        }
    }

}