using System;

namespace LabExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double numOfYears;
         double rateAfter5Years = 7.5;
         double rateBefore5Years = 5.4;

         Console.WriteLine("Enter the number of years the money was left in your account: ");
         numOfYears = Convert.ToDouble(Console.ReadLine());

         
         //Processing



         //Output

         if (numOfYears >= 5)
            {
                Console.WriteLine($"Your rate is {rateAfter5Years}%");
            }
         else
            {
                Console.WriteLine($"Your rate is {rateBefore5Years}%");
            }
        }
    }
}
