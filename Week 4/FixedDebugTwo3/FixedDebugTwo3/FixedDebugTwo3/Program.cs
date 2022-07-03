using System;

namespace FixedDebugTwo3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double WITHHOLDING_RATE = 0.15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, net;

            Console.Write("Enter the number of hours you worked this week: ");
            hoursAsString = Console.ReadLine();
            Console.Write("Enter your hourly rate: ");
            rateAsString = Console.ReadLine();

            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);
            gross = hours * rate;
            net = gross - WITHHOLDING_RATE * gross;
            Console.Write($"You made {net.ToString("C")}");
        }
    }
}
