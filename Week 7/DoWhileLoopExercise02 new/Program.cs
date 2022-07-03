using System;

namespace DoWhileLoopExercise02_new
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
            } while (counter < 21);
        }
    }
}
