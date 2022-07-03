using System;

namespace NestedLoopExercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            string integer;
            int counter;
            string reversed = "";
            
            
            do
            {
                Console.WriteLine("Enter a positive integer: ");
                integer = Console.ReadLine();
                counter = integer.Length - 1;
                for (int i = counter; i >= 0; i--)
                {
                    reversed += integer[i];
                }

            } while (reversed.Length < integer.Length);
            Console.WriteLine(reversed);
        }
    }
}
