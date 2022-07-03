using System;

namespace DoWhileLoopExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            string ast = "*";

            do
            {
                if (counter%5 == 0)
                { 
                    Console.WriteLine(counter);
                    Console.WriteLine(ast);
                    counter++;
                    ast += "*";
                }
                else
                {
                    Console.WriteLine(counter);
                    counter++;
                    ast += "*";
                }
            } while (counter < 21);
        }
    }
}
