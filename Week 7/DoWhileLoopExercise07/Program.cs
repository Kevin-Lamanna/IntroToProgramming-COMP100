using System;

namespace DoWhileLoopExercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int inputNumber;
            int sumOfNumbers = 0;

            do
            {
                //Input
                Console.WriteLine("Please enter a number: ");
                inputNumber = Convert.ToInt32(Console.ReadLine());

                //Process
                sumOfNumbers = sumOfNumbers + inputNumber;
                // sumOfNumbers += inputNumber;
            } while (sumOfNumbers <= 100);


            //Output

            Console.WriteLine($"The sum is {sumOfNumbers}");
            Console.ReadKey();
        }
    }
}
