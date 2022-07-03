using System;

namespace DoWhileLoopExercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber;
            int sumOfNumbers = 0;
            int counter = 0;
            int average;

            do
            {
                //Input
                Console.WriteLine("Please enter a number: ");
                inputNumber = Convert.ToInt32(Console.ReadLine());

                counter++; //counter += 1  or counter = counter + 1

                //Process
                sumOfNumbers = sumOfNumbers + inputNumber;
                // sumOfNumbers += inputNumber;
            } while (sumOfNumbers <= 100);

            average = sumOfNumbers / counter;

            //Output

            Console.WriteLine($"The sum is {sumOfNumbers}");
            Console.WriteLine($"The average is {average}");
            Console.ReadKey();
        }
    }
}
