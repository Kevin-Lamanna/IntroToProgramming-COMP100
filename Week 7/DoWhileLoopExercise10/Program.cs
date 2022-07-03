using System;

namespace DoWhileLoopExercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int celsius = 100;
            int fahrenheit;

            //{:F} two decimal points  {:F3}  three decimal points

            //Processing
            Console.WriteLine("----------------------");
            Console.WriteLine("  Celsius   Fahrenheit");
            Console.WriteLine("----------------------");
            do
            {
                fahrenheit = 9 / 5 * celsius + 32;
                Console.WriteLine($"|    {celsius, 5} | {fahrenheit, 7} |");
                celsius -= 10;
            }
            while (celsius >= 0);

            //Output
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
