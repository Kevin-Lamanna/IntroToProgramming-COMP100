using System;

namespace SimpleLoopExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int feet = 3;
            double meters;

            Console.WriteLine("  Feet  | Meters");
            Console.WriteLine("--------|--------");

            //do
            //{
            //    meters = feet * 3.28;

            //    Console.WriteLine($"   {feet, -2}   |  {Convert.ToDecimal(meters), 3}");
            //    feet++;
            //} while (feet <= 30);

            //while (feet <= 30)
            //{
            //    meters = feet * 3.28;

            //    Console.WriteLine($"   {feet,-2}   |  {Convert.ToDecimal(meters),3}");
            //    feet++;
            //}

            for (int i = 3; i <= 30; i++)
            {
                meters = feet * 3.28;

                Console.WriteLine($"   {feet,-2}   |  {Convert.ToDecimal(meters),-3:N2}");
                feet++;
            }
            // For two decimal places { myVariable:N2}
        }
    }
}
