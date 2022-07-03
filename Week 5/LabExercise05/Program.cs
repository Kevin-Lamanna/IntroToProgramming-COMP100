using System;

namespace LabExercise05
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         int IQ;

         Console.WriteLine("Enter your IQ score: ");
         IQ = Convert.ToInt32(Console.ReadLine());

         //Processing

         //Output
         if (IQ < 0 || IQ > 200)
            {
                Console.WriteLine("Error, One's IQ cannot have these values");
            }
         else
                if (IQ > 100)
                    {
                     Console.WriteLine("Above average");
                    }
                else
                    if (IQ == 100)
                        {
                            Console.WriteLine("Average");  
                        }
                    else
                        {
                            Console.WriteLine("Below average");
                        }

         
        }
    }
}
