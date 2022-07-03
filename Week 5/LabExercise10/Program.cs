using System;

namespace LabExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double hourlyPayRate;
         double weeklyPayRate;

         Console.WriteLine("Enter your hourly pay rate: ");
         hourlyPayRate = Convert.ToDouble(Console.ReadLine());

            if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
            {
                Console.WriteLine("Enter your hourly pay rate: ");
                hourlyPayRate = Convert.ToDouble(Console.ReadLine());
                if (hourlyPayRate < 7.50 || hourlyPayRate > 49.99)
                {
                    Console.WriteLine("Entered value is outside of plausible wage range");
                }
                else
                {
                    weeklyPayRate = 40 * hourlyPayRate;
                    Console.WriteLine($"Hourly pay rate: ${hourlyPayRate} Weekly pay rate: ${weeklyPayRate}");
                }
            }
            else
            {
                weeklyPayRate = 40 * hourlyPayRate;
                Console.WriteLine($"Hourly pay rate: ${hourlyPayRate} Weekly pay rate: ${weeklyPayRate}");
            }
         


         
        }
    }
}
