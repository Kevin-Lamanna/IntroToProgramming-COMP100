using System;

namespace Nested_Exercise_5_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double hourlyPayRate;
            double weeklyPayRate;

            Console.WriteLine("Enter hourly pay rate: ");
            hourlyPayRate = Convert.ToDouble(Console.ReadLine());
           
            // 5
            if (hourlyPayRate < 5.65)
            {
                Console.WriteLine("Error: Rate is too low");
            }

            // 6
            if ((hourlyPayRate < 5.65) || (hourlyPayRate > 49.99))
            {
                Console.WriteLine("Error: Rate is not within acceptable range");
            }

            // 7
            if ((hourlyPayRate < 5.65) || (hourlyPayRate > 49.99))
            {
                Console.WriteLine("Enter hourly pay rate: ");
                hourlyPayRate = Convert.ToDouble(Console.ReadLine());

                if ((hourlyPayRate < 5.65) || (hourlyPayRate > 49.99))
                {
                    Console.WriteLine("Error: Rate is not within acceptable range");
                }
                else
                {
                    weeklyPayRate = 40 * hourlyPayRate;
                    Console.WriteLine($"Hourly Pay Rate: {hourlyPayRate:C} Weekly Pay Rate: {weeklyPayRate:C}");
                }      
            }
            else
            { 
                weeklyPayRate = 40 * hourlyPayRate;
                Console.WriteLine($"Hourly Pay Rate: {hourlyPayRate:C} Weekly Pay Rate: {weeklyPayRate:C}");
            }
        }
    }
}
