using System;

namespace LabExercise15
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         Random ranNumberGenerator = new Random();
         int randomNumber;
         randomNumber = ranNumberGenerator.Next(1, 11);
         int userNum;

         Console.WriteLine("Guess a number from 1 - 11: ");
         userNum = int.Parse(Console.ReadLine());

         //Output
         if (userNum == randomNumber)
            {
                Console.WriteLine("Correct");
            }
         else if (userNum < randomNumber)
            {
                Console.WriteLine("Too low");
            }
         else
            {
                Console.WriteLine("Too high");
            }

        }
    }
}
