using System;

namespace LabExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double hourlyPayRate;

         Console.WriteLine("Enter your hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());

         //Output
         if (hourlyPayRate < 7.50)
            {
                Console.WriteLine("Error: Hourly pay is too low!");
            }
         
        }
    }
}
