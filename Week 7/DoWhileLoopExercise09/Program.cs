using System;

namespace DoWhileLoopExercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int count = 0;
            int multipleOf3 = 1000000;
            long sum = 0;


            //Processing
            do
            {
                if (multipleOf3%3 ==0)
                {
                    sum += multipleOf3;
                    multipleOf3++;
                }
                else
                {
                    multipleOf3++;
                }
            }
            while (multipleOf3 < 2000000);

            //Output
            Console.WriteLine($"Sum is {sum:N}");
            Console.ReadKey();


        }
    }
}
