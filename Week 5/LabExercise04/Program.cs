using System;

namespace LabExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         int messageLength;
         string message;
         
         Console.WriteLine("Enter a message: ");
         message = Console.ReadLine();
         
         //Processing
         messageLength = message.Length;


         //Output
         if (messageLength > 140)
            {
                Console.WriteLine("Message is too long because it exheeds 140 characters");
            }
         else
            {
                Console.WriteLine("Message is of acceptable length");
            }

         
        }
    }
}
