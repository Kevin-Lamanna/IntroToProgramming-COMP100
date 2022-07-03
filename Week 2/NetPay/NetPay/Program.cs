using System;

namespace NetPay
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            string name;
            string sin;
            double hourlyRate;
            int hours;

            Console.Write("Enter your name: ");
            name = Console.ReadLine();

            Console.Write("Enter your Social Insurance Number: ");
            sin = Console.ReadLine();

            Console.Write("Hourly pay rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Hours Worked: ");
            hours = Convert.ToInt32(Console.ReadLine());

            //PROCESS
            double grossPay;
            double federalTax = 15;
            double provincialTax = 10;

            grossPay = hours * hourlyRate;

            double federalAmount;
            double provincialAmount;
            double netAmount;

            federalAmount = grossPay * federalTax / 100;
            provincialAmount = grossPay * provincialTax / 100;

            netAmount = grossPay - federalAmount - provincialAmount;

            //OUTPUT
            Console.WriteLine(" ");
            Console.WriteLine($"Payroll Summary for {name}");
            Console.WriteLine($"SIN: {sin}");
            Console.WriteLine($"You worked {hours} hours at {hourlyRate.ToString("c")} per hour");

            Console.WriteLine($"Gross pay:       {grossPay.ToString("c"), 15}");
            Console.WriteLine($"Federal Tax:     {federalAmount.ToString("c"), 15}");
            Console.WriteLine($"Provincial Tax:  {provincialAmount.ToString("c"), 15}");
            Console.WriteLine($"--------------------------------");
            Console.WriteLine($"Net Pay:         {netAmount.ToString("c"), 15}");

            //last notes
            //monetary values use decimal or double; especially decimal
            //don't use floats
            //no penalization for variant choices. Try to use ints for non decimal values
        }
    }
}
