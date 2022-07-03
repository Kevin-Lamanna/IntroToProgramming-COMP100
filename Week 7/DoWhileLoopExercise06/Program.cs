using System;

namespace DoWhileLoopExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 20;

            do
            {
                if (counter % 3 == 0)
                {
                    counter++;
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine(counter);
                    counter++;
                }
            } while (counter < 61);
        }
    }
}
