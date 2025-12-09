using HideNSeek;

public class Program
{
    public static int round = 0;
    public static int score = 0;

    public static void Main(string[] args)
    {
        GameStart();
        Hider hider = new Hider();
        for (;;)
        {
            Spots spots = new Spots();
            RoundStart();
            Spots.HidingSpots();
            RoundEnd();
        }
    }
    
    public static void GameStart()
    {
        Console.WriteLine("Welcome to Hide And Seek! Your goal is to find the hider in 3 attempts.");
        Console.WriteLine("The quicker you find the hider, the more points you will get. Good luck!");
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