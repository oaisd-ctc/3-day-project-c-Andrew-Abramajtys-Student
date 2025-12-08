using System;


public class Program
{
    public static void Main(string[] args)
    {
        hidingSpots();
    }
    public static void hidingSpots()
    {

        for (int i = 0; i <= 3; i++)
        {
            string[] spots ={"Cabinet", "Fridge", "Closet", "Bed", "Desk", "Laundry", "Attic"};
            Console.WriteLine("Pick a spot you think they might be hiding in. The Cabinet, Fridge, Closet, Bed, Desk, Laundry, or Attic.");
            string hidingspot = " ";
            foreach(string word in spots)
            {
                string spot = Console.ReadLine();
                if (word == hidingspot)
                {
                    Console.WriteLine("you found them congratgulations, on to the next round.");
                    break;
                }

                if(word != hidingspot)
                {
                    Console.WriteLine("you guessed wrong try again");
                    Console.WriteLine(" ");
                    i++;
                }

                if ( == 3)
                {
                    Console.WriteLine("Looks like they win, Try Again.");
                    break;
                }

                else
                {
                    Console.WriteLine("Thats not a hiding spot try looking somewhere else.");
                    i++;
                }
            }
            
        }
    }
}