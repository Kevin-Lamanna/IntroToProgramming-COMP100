using System;

namespace LabExercise18
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         Random ranNumberGenerator = new Random();
         int randomNumber1, randomNumber2, randomNumber3;
         randomNumber1 = ranNumberGenerator.Next(1, 5);
         randomNumber2 = ranNumberGenerator.Next(1, 5);
         randomNumber3 = ranNumberGenerator.Next(1, 5);

         int firstGuess, secondGuess, thirdGuess;
         Console.WriteLine("First number: Guess an integer between 1 and 4");
         firstGuess = int.Parse(Console.ReadLine());
         Console.WriteLine("Second number: Guess an integer between 1 and 4");
         secondGuess = int.Parse(Console.ReadLine());
         Console.WriteLine("Third number: Guess an integer between 1 and 4");
         thirdGuess = int.Parse(Console.ReadLine());

         //Processing
         int award;
         if (randomNumber1 == firstGuess & randomNumber2 == secondGuess & randomNumber3 == thirdGuess)
            {
                award = 10000;
                Console.WriteLine($"Your award is {award.ToString("C")}");
            }
         else if ((randomNumber1 == firstGuess & randomNumber2 == secondGuess) || (randomNumber2 == secondGuess & randomNumber3 == thirdGuess) || (randomNumber1 == firstGuess & randomNumber3 == thirdGuess))
            {
                award = 100;
                Console.WriteLine($"Your award is {award.ToString("C")}");
            }
         else if (randomNumber1 == firstGuess || randomNumber2 == secondGuess || randomNumber3 == thirdGuess)
            {
                award = 10;
                Console.WriteLine($"Your award is {award.ToString("C")}");
            }
         else
            {
                award = 0;
                Console.WriteLine($"Your award is {award.ToString("C")}");
            }
        }
    }
}
