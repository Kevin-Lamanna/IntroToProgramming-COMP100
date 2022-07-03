using System;

namespace FixedDebugTwo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            int enteredInteger;
            int more;
            int less;

            Console.Write("Enter an integer: ");
            entry = Console.ReadLine();
            Console.WriteLine("You entered {0}", entry);
            enteredInteger = Convert.ToInt32(entry);

            more = enteredInteger + 1;
            less = enteredInteger - 1;

            Console.WriteLine("One more than {0} is {1} and one less than {0} is {2}",
                enteredInteger, more, less);
        }
    }
}
