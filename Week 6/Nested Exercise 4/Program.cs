using System;

namespace Nested_Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shift down key shortcut for multiple line selection
            // Input
            int a;
            int b;
            int c;
            int d;
            double p;
            double q;


            Console.WriteLine("Enter a value for a, the first coefficient: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter a value for b, the second coefficient: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for c, the third coefficient: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for d: ");
            d = Convert.ToInt32(Console.ReadLine());

            // Processing
            
            if (a == 0)
            {
                Console.WriteLine("Invalid input for a");
            }
            else
            {
                Console.WriteLine($"p = -b/2a   d = b^2 - 4ac");
                p = (-b) / (2.00 * a);       // 2.00 makes a decimal operation
                d = (b*b) - (4 * a * c);

                if (d >=0)
                {
                    Console.WriteLine("q = Math.Sqrt(d)/2a");
                    q = Math.Sqrt(d) / (2.00 * a);
                    Console.WriteLine("p + q and p - q");
                    Console.WriteLine($"{p:F} + {q:F} and {p:F} - {q:F}");
                }
                else
                {
                    Console.WriteLine("q = Math.Sqrt(-d)/2a");
                    q = Math.Sqrt(-d) / (2 * a);
                    Console.WriteLine("p + qi and p - qi");
                    Console.WriteLine($"{p:F} + {q:F}i and {p:F} - {q:F}i");
                }
            }
        }
    }
}
