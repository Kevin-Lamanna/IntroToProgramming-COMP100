using System;

namespace PracticeWithMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayPersonalInformation();
            DisplayAreaOfCircle(4);
            double tax = CalculateTax(10);
            Console.WriteLine($"The tax is {tax:C}");
            Console.ReadKey();

            double volume = GetVolumeOfCube();
            Console.WriteLine($"The volume of the cuboid is {volume:F1}");
            

        }

        // Question 1
        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Kevin Lamanna");
            Console.WriteLine("Software Program");
            Console.WriteLine("Comp100");
        }
        // Question 2
        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The area of the circle is {area:F2}");
        }
        // Question 3
        static double CalculateTax(double price)      // Study this example
        {
            double taxAmount = price * 0.14;
            return taxAmount;
        }
        // Question 4
        static double GetVolumeOfCube()              // Study this example
        {
            double length;
            double width;
            double height;
            
            Console.WriteLine("Enter the length: ");
            length = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the width: ");
            width = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the height: ");
            height = Convert.ToDouble(Console.ReadLine());

            double getVolume = length * width * height;
            return getVolume;
        }
    }
}
