using System;

namespace SimpleLoopExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sum = 0;
            double average;

            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine($"Enter integer value #{i}");
            //    sum = sum + Convert.ToInt32(Console.ReadLine());
            //}
            //average = sum / 10;
            //Console.WriteLine($"The average of these numbers is {average}");

            //while (counter <=10)
            //{
            //    Console.WriteLine($"Enter integer value #{counter}");
            //    sum = sum + Convert.ToInt32(Console.ReadLine());
            //    counter++;
            //}
            //average = sum / 10;
            //Console.WriteLine($"The average of these numbers is {average}");

            do
            {

                Console.WriteLine($"Enter integer value #{counter}");
                sum = sum + Convert.ToInt32(Console.ReadLine());
                counter++;

            } while (counter <= 10);
            average = sum / 10;
            Console.WriteLine($"The average of these numbers is {average}");
        }
    }
}
