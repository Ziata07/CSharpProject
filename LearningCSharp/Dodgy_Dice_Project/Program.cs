using System;
using DiceLibrary;
//The dice used here are skewed, where if the player name is 'Rob' then the resules on the dice will average higher than on another name.
namespace Dodgy_Dice_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpots = 0;
            DiceClass dice = new DiceClass();

            for (int x = 0; x < 1000; x++)
            {
                dice.SetPlayer("Fred");
                averageSpots += dice.IntSpots();

                if (x == 999)
                {
                    Console.WriteLine($"Total number of spots is: {averageSpots}");
                    Console.WriteLine($"The average is: {averageSpots / 1000}");
                }
            }
            Console.ReadKey();
        }
    }
}
