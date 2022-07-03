using System;

namespace ConditionalRangeHourlyPay02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double rate;

            Console.Write("What is the Hourly Py Rate? ");

            rate = Convert.ToDouble(Console.ReadLine());
            //rate = double.Parse();

         
         //Processing


         
         //Output
         //If there is only one line in the if/else statements: We can ommit the {}
         if (rate < 7.50 || rate > 49.99)
            {
                Console.WriteLine("Error: rate is outside the range!");
            }
         else
            {
                Console.WriteLine("Rate is OK!");
            }
        }
    }
}
