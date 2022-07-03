using System;

namespace MethodPractice
{
    class Program
    {
        static void Main(string[] args)        // Name, return type, type, arguments
                                               // Keyword modifier
        {
            Console.WriteLine("Kevin");        // Method body
            DisplayPersonalInformation();      // This method will not run if commented out
            DisplayAreaOfCircle(3);
        }

        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Narendra Pershad");
            Console.WriteLine("Professor");
            Console.WriteLine("Centennial College");
        }

        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"A circle with radius of {radius:f2} will have an area of {area:f2}");   
        }
    }
}
