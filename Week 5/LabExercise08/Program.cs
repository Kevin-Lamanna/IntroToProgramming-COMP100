using System;

namespace LabExercise08
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         string operation;
         int num1;
         int num2;

         Console.WriteLine("Enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter a second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Enter an operation: A, S, or M?");
            operation = Console.ReadLine();


         //Processing + Output
         int result;
         if (operation == "M")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
         if (operation == "A")
            {
                result = num1 + num2;
                Console.WriteLine(result);
            }
         if (operation == "S")
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
         
        }
    }
}
