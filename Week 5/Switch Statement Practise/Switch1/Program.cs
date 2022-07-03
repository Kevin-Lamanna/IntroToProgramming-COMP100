using System;

namespace Switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Let's do some switch statement practice!
            //Switch statements are extremely useful for program control flow

            //Input

            //Variable and constand declarations, nitializations, and input

            int num;
            char vowel;

            Console.WriteLine("Enter an ineger less than 6: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Processing and Output

            //What types of variables can switch statements take?
            // Answer: A switch works with the byte , short , char , and int primitive data types
            // That means that switch statements do not work with Booleans!!!
            // Use if, else if, and else statements for boolean expressions!
            // Unlike if, else if, and else statements, the code embedded in each switch statement case does not require curly braces.

            switch (num)
            {
                case 1:
                     Console.WriteLine("You entered 1 ");
                     break;
                case 2:
                     Console.WriteLine("You entered 2 ");
                     break;
                case 3:
                     Console.WriteLine("You entered 3 ");
                     break;
                case 4:
                     Console.WriteLine("You entered 4 ");
                     break;
                case 5:
                     Console.WriteLine("You entered 5 ");
                     break;
                default:
                     Console.WriteLine("You entered an incorrect value ");
                     break;
            }

            Console.WriteLine("");

            Console.WriteLine("Enter a vowel: ");
            vowel = Convert.ToChar(Console.ReadLine());

            // Additionally, we can group cases together by placing multiple cases without case blocks above a case that has a case block.
            // We can say that these cases share a case block.
            // " " are for strings and ' ' are for chars! Very Important in C#; especially, for switch statements.

            switch(vowel)
            {
                case 'a':
                case 'e':
                case 'i':
                    Console.WriteLine("You have entered a front vowel");
                    break;
                case 'o':
                case 'u':
                    Console.WriteLine("You have entered a back vowel");
                    break;
                case 'y':
                    Console.WriteLine("'y' is just 'i' in disguise");
                    break;
                default:
                    Console.WriteLine("You must have entered a consonant or a non-English vowel");
                    break;
            }
        }
    }
}
