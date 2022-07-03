using System;

namespace LabExercise17
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerChoice;
            string computerChoice;
            Console.WriteLine("Choose a letter from the following: r, p, or s? ");
            playerChoice = Console.ReadLine();

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(1, 4);

          if (randomNumber == 1)
            {
                computerChoice = "r";
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Tie!");
                }
                else if (playerChoice == "s")
                {
                    Console.WriteLine("Computer wins!");
                }
                else if (playerChoice == "p")
                {
                    Console.WriteLine("Player wins!");
                }
            }
          else if (randomNumber == 2)
            {
                computerChoice = "p";
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Tie!");
                }
                else if (playerChoice == "r")
                {
                    Console.WriteLine("Computer wins!");
                }
                else if (playerChoice == "s")
                {
                    Console.WriteLine("Player wins!");
                }
            }
          else if (randomNumber == 3)
            {
                computerChoice = "s";
                if (playerChoice == computerChoice)
                {
                    Console.WriteLine("Tie!");
                }
                else if (playerChoice == "p")
                {
                    Console.WriteLine("Computer wins!");
                }
                else if (playerChoice == "r")
                {
                    Console.WriteLine("Player wins!");
                }
            }
           
        }
    }
}
