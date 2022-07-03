using System;

namespace SimpleLoopExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int counter = 0;

            //for (int i = 1; i < 9; i++)
            //{
            //    Console.WriteLine($"Please enter value #{i}: ");
            //    sum = sum + Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"The sum of these numbers is {sum}");

            //while (counter < 8)
            //{
            //    counter++;
            //    Console.WriteLine($"Please enter value #{counter}: ");
            //    sum = sum + Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"The sum of these numbers is {sum}");

            do
            {

                counter++;
                Console.WriteLine($"Please enter value #{counter}: ");
                sum = sum + Convert.ToInt32(Console.ReadLine());
            } while (counter < 8);
            Console.WriteLine($"The sum of these numbers is {sum}");
        }
    }
}
