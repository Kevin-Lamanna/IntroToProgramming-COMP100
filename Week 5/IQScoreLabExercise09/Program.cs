using System;

namespace IQScoreLabExercise09
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         int iqScore;
         
         Console.Write("Please enter the IQ: ");
         iqScore = int.Parse(Console.ReadLine());

         

         //Processing

         //Output
         //Wee can use multiple if statements if they are not reletaed

         if (iqScore < 0 || iqScore > 200)
            {
                Console.WriteLine("Error: IQ score is invalid");
            }
         else
                if (iqScore > 100)
                {
                Console.WriteLine("Above Average");
                }
                else if (iqScore == 100)
                {
                 Console.WriteLine("Average");
                }
                else
                {
                Console.WriteLine("Below Average");
                }
        }
    }
}
