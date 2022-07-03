using System;

namespace DoWhileLoopExercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string ast = "";

            do
            {

                ast += "* ";
                counter++;

            } while (counter < 5);
            Console.WriteLine(ast);
        }
    }
}
