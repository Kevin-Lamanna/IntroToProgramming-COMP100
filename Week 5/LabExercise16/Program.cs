using System;

namespace LabExercise16
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         string player1Choice;
         string player2Choice;

         Console.WriteLine("Player 1 - Choose from the following: rock, paper, or scissors? ");
         player1Choice = Console.ReadLine();

         Console.WriteLine("Player 2 - Choose from the following: rock, paper, or scissors? ");
         player2Choice = Console.ReadLine();

         //Output
         if (player1Choice == player2Choice)
            {
                Console.WriteLine("Tie!");
            }
         else if (player1Choice == "rock")
            {
                if (player2Choice == "paper")
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    Console.WriteLine("Player 1 wins!");
                }
            }
         else if (player1Choice == "paper")
            {
                if (player2Choice == "scissors")
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    Console.WriteLine("Player 1 wins!");
                }
            }
         else if (player1Choice == "scissors")
            {
                if (player2Choice == "rock")
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else
                {
                    Console.WriteLine("Player 1 wins!");
                }
            }

        }
    }
}
