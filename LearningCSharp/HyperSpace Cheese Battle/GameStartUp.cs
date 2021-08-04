using System;

namespace HyperspaceCheese
{
    class GameStartUp
    {       
         public static void RunGame()
        {
            string newGame;
            do
            {
                GameMechanics.ResetGame();
                GameMechanics.MakeMoves();

                Console.WriteLine("Do you want to play again? Press 'Enter' to start new game or press any key to close the application!\n");
                newGame = Console.ReadLine();

            } while (String.Equals(newGame, String.Empty));
        }                 
    }
}