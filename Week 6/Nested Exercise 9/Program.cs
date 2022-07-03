using System;

namespace Nested_Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double hourlyPayRate;
            double hoursWorked;
            double withholdingTax;

            Console.WriteLine("Enter Hourly Pay Rate: ");
            hourlyPayRate = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Hours worked: ");
            hoursWorked = Double.Parse(Console.ReadLine());

            // Processing
            double grossPay = hourlyPayRate*hoursWorked;
            double netPay;

            if (grossPay >= 300.01)
            {
                withholdingTax = grossPay * 0.12;
            }
            else
            {
                withholdingTax = grossPay * 0.10;
            }

            // Output

            netPay = grossPay - withholdingTax;

            Console.WriteLine($"Gross Pay: {grossPay:C} Withholding Tax: {withholdingTax:C} Net Pay: {netPay:C}");

        }
    }
}
