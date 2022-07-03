using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int var_a = 5;
            Console.WriteLine($"Before method call {var_a}");
            Twice(var_a, out var_a);
            Console.WriteLine("After method call {var_a}");     // var_a == 10 because of 'ref'
                                                                // Reference to the position in memory
                                                                // No 'ref' would return a copy (different memory locations)

            // out vs. ref
            // Only returns a value; does not arrive with a value.
            // value will be ignored
            // a is declared but not initialized; so, we cannot use the variable
            // ref accepts a value, out does not not accept a value.
            // Out is used to return multiple values
            // Use out and ref when returning multiple values
            // Must initialize the variable to use 'ref'


            Console.WriteLine($"Tuition fees {CalculateFees(5, 549.99):C}");

            Console.WriteLine($"Tuition fees {CalculateFees(numberOfCourses: 5, cost: 549.99):C}");

            Console.WriteLine($"Tuition fees {CalculateFees(cost: 549.99, numberOfCourses: 5):C} ");

            Console.WriteLine($"Tuition fees {AddFees(250, 350):C} ");

            // If we only want to pass a value to fee02, then we must expelicitly write the variable in the method call.
            Console.WriteLine($"Tuition fees {AddFees(fee02: 250):C} ");

            // If you don't name your arguments, you have to follow the argument order
        }

        public static void Twice(int initialValue, out int a)
        {
            a *= 2;
            Console.WriteLine("In method call {a}");
        }


        static double CalculateFees(int numberOfCourses, double cost = 700)  //700 by default. Optional argument.
        {
            return numberOfCourses * cost;
        }

        static double AddFees(double fee01 = 1000, double fee02 = 700)
        {
            Console.WriteLine($"Fee 01: {fee01:C}");
            Console.WriteLine($"Fee 02: {fee02:C}");
            return fee01 + fee02;
        }

       
    }
}
