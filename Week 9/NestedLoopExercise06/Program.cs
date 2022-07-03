using System;

namespace NestedLoopExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            const double INITIAL_INVESTMENT = 1000.00;
            double moneyAvailable = 1000.00;
            int interestRate = 6;
            int totalInvestedYears = 0;
            

            Console.WriteLine($"Initial investment: {INITIAL_INVESTMENT:C}");
            while (interestRate <= 12)
            {
                int years = 0;
                while (years < 10)
                {
                    moneyAvailable += moneyAvailable * interestRate / 100;
                    years++;
                }
                totalInvestedYears += years;
                Console.WriteLine($"Available money after {totalInvestedYears} years: {moneyAvailable:C}");
                interestRate++;
            }
        }
    }
}
