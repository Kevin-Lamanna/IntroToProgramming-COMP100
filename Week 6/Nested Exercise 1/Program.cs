using System;

namespace Nested_Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter;

            Console.WriteLine("Enter a single English letter: ");
            letter = Console.ReadLine();

            switch(letter.ToLower()) //Super important to use To lower. Now we can take input regardless of case.
            {
                case "a":
                    Console.WriteLine("Apple");
                    break;
                case "b":
                    Console.WriteLine("Baby");
                    break;
                case "c":
                    Console.WriteLine("Candy");
                    break;
                default:
                    Console.WriteLine("Sorry, I don't know that letter.");
                    break;
            }
        }
    }
}
