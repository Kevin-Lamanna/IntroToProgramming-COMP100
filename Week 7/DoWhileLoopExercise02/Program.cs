using System;

namespace DoWhileLoopExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 6);
        }
    }
}
