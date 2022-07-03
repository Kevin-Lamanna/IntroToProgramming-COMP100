using System;

namespace incrementDecrement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1

            int a, b;
            a = 10;

            Console.WriteLine(++a); // Updates the value of a, then displays its value
            // prints 11 (a = a + 1) (a == 11)
            Console.WriteLine(a++); // Displays the value of a, then updates its value
            // prints 11 then updates a's value (a = a + 1) (a == 12)
            Console.WriteLine(a);

            b = a;
            Console.WriteLine(a); // a's value is now equal to 12
            Console.WriteLine(b); // b's value is equal to a's which is 12

            int c, d;
            c = 10;

            Console.WriteLine(--c); // Updates the value of c, then displays its value.
            // prints 9 (c = c - 1) (c == 9)
            Console.WriteLine(c--); // Displays the value of c, then updates its value.
            // prints 9 then updates its value (c = c - 1) (c == 8)
            Console.WriteLine(c);

            d = c;
            Console.WriteLine(c); // c's value is now equal to 8.
            Console.WriteLine(d); // d's value is equal to c's which is 8


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            // Example 2

            int userAge = 41;
            userAge = userAge + 1;
            userAge = userAge - 1;

            // Postfix increment/decrement: Assign/Print the value before updating it

            userAge = 41;
            userAge++;      // userAge == 42
            Console.WriteLine("Age of user: " + userAge);
            Console.WriteLine(userAge);

            userAge = 41;
            Console.WriteLine("Age of user: " + userAge++); // the value userAge gets updated AFTER the statement is printed (printed value is 41)
            Console.WriteLine(userAge); // userAge's value is now 42 (different from just printing userAge + 1 because the ++ operator updates the value of the variable as well.

            // Prefix increment/decrement: Update the variable before assigning it or printing it

            userAge = 41;
            Console.WriteLine("Age of user: " + ++userAge); // the value of userAge gets updated BEFORE the statement is printed.
            Console.WriteLine(userAge); // The new value of userAge (42) is printed with the statement.


            // This process is similar for the prefix/postfix decrement operator

            userAge = 41;
            Console.WriteLine("Age of user: " + (userAge--)); // prints 41 then updates the value of userAge.
            Console.WriteLine(userAge);

            userAge = 41;
            Console.WriteLine("Age of user " + (--userAge)); // updates the value of userAge, then prints 40.
            Console.WriteLine(userAge);
         
        }
    }
}
