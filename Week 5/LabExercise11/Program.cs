using System;

namespace LabExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double gpa;
         double testScore;

         Console.WriteLine("Enter your numeric grade point average: ");
         gpa = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Enter your admission test score: ");
         testScore = Convert.ToDouble(Console.ReadLine());

         //Output

         if (gpa >= 3.0 & testScore>=60)
            {
             Console.WriteLine("Accept");
            }
         else if(gpa<3.0 & testScore>=80)
            {
             Console.WriteLine("Accept");
            }
         else
            {
             Console.WriteLine("Reject");
            }
        }
    }
}
