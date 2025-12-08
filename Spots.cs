using System;
using System.Linq;
namespace HideNSeek;


public class Spots
{
    public Spots()
    {
        
    }

    public static void HidingSpots()
    {
        Hider hider = new Hider();
        hider.ResetSpot();

        string[] spots = { "Cabinet", "Fridge", "Closet", "Bed", "Desk", "Laundry", "Attic" };
        int attempts = 0;

        while (attempts < 3)
        {
            Console.WriteLine("Pick a spot you think they might be hiding in. The Cabinet, Fridge, Closet, Bed, Desk, Laundry, or Attic.");
            string? spot = Console.ReadLine();
            
            if (spot == "end")
            {
                Environment.Exit(0);
            }

            if (string.IsNullOrWhiteSpace(spot))
            {
                Console.WriteLine("Please enter a spot.");
                continue;
            }

            if (!spots.Contains(spot, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Thats not a hiding spot try looking somewhere else.");
                continue;
            }

            int spotChoice = hider.GetSpotChoice();
            string hiderSpot = spots[spotChoice];

            if (string.Equals(spot, hiderSpot, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You found them congratulations, on to the next round.");
                Program.score = Program.score + (3 - attempts);
                break;
            }
            else
            {
                attempts++;
                if (attempts == 3)
                {
                    Console.WriteLine("Looks like they win, Try Again.");
                    break;
                }
                Console.WriteLine("You guessed wrong, try again.");
                Console.WriteLine();
            }
        }
    }
}