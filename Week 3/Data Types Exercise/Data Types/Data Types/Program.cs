using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
         //First Program
         string firstName, middleInitial, lastName;
            Console.WriteLine("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the first letter of your middle name: ");
            middleInitial = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName}");
            Console.WriteLine($"{firstName} {middleInitial} {lastName}");
            Console.WriteLine($"{lastName}, {firstName} {middleInitial}");

         //Second Program
         int siblingNum;
            Console.WriteLine("How many siblings do you have? ");
            siblingNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I also have {siblingNum} siblings");
         
         //Third Program
         int num1, num2;
            Console.WriteLine("Enter an integer: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2} = {(num1 + num2)} and {num1} - {num2} = {num1 - num2}");

         //Fourth Program
         int numOfSiblings;
            Console.WriteLine("Enter the number of siblings you have: ");
            numOfSiblings = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I have {numOfSiblings + 1} siblings");
         
        }
    }
}
