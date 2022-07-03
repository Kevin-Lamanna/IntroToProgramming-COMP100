using System;

namespace NestedLoopsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double yearlyAmountAval;
            double investment;
            double interest;
            int year = 0;

            Console.WriteLine("Enter your initial investment: ");
            investment = Convert.ToDouble(Console.ReadLine());

            //Processing + Output
            Console.WriteLine("  Year  |   Annual Amount   ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"  {year,3}   |    {investment:C}");
            for (int i = 6; i <= 12; i++)        // Every 10 years  (max 70 years)
            {
                for (int j = 1; j <= 10; j++)    // 1 to 10 years   (max 10 years)
                {
                    interest = Convert.ToDouble(i) / 100;
                    investment += investment * interest;
                    yearlyAmountAval = investment;
                }
                year += 10;
                Console.WriteLine($"  {year, 3}   |    {investment:C}"); 
            }
        }
    }
}
