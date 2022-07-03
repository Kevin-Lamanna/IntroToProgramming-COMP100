using System;

namespace NestedLoopExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUM_OF_EXPERIMENTS = 4;
            int NUM_OF_RESULTS;
            double results;
            double experiment_Num;

            // Loop over experiments
            for (int experiment = 1; experiment <= NUM_OF_EXPERIMENTS; experiment++)
            {
                Console.WriteLine($"Enter the number of tests for experiment {experiment}: ");
                NUM_OF_RESULTS = Convert.ToInt32(Console.ReadLine());
                results = 0;
                Console.WriteLine($"Enter the test results for experiment {experiment}: ");
                // Loop over test results
                for (int test = 1; test <= NUM_OF_RESULTS; test++)
                {
                    Console.WriteLine($"Test {test}: ");
                    results += Convert.ToDouble(Console.ReadLine());
                }
                double averageResult = results / NUM_OF_RESULTS;
                Console.WriteLine($"The average test result for experiment {experiment} is {averageResult:N2}");
            }
        }
    }
}
