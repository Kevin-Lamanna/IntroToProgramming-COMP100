using System;

namespace DoWhileLoopExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 10;
            string ast = "*";

            do
            {
                if (counter % 7 == 0)
                {
                    ast += "*";
                    Console.WriteLine(ast);
                    Console.WriteLine(counter);
                    counter++;  
                }
                else
                {
                    Console.WriteLine(counter);
                    counter++;
                }
            } while (counter < 41);
        }
    }
}
