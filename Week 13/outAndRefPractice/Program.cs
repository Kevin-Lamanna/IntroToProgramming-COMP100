using System;

namespace outAndRefPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 50;
            int second = 100;
            int sum;
            int difference;

            sum = Add(ref first, ref second);
            difference = Subtract(out first, out second);

            Console.WriteLine($"The firt value is {first}");
            Console.WriteLine($"The second value is {second}");
            Console.WriteLine($"The sum is {sum}");
            Console.WriteLine($"The difference is {difference}");

            
        }

        static int Add(ref int a, ref int b)
        {
            int result;
            result = a + b;

            b = 1000;
            a = 500;

            return result;
  
        }

        static int Subtract(out int a, out int b)
        {
            int result;

            b = 1000;
            a = 500;
            result = b - a;

            return result;
        }
    }
}
