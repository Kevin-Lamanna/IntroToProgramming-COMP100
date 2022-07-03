using System;

namespace Nested_exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double gpa;
            double testScore;

            Console.WriteLine("Enter your numeric Grade Point Average: ");
            gpa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your admission test score: ");
            testScore = Double.Parse(Console.ReadLine());

            //Processing
            string decision;

            if ((gpa >= 3.0) && (testScore >= 60))
            {
                decision = "Accept";
            }
            else if ((gpa < 3.0) && (testScore >= 80))
            {
                decision = "Accept";
            }
            else
            {
                decision = "Reject";
            }

            //Output
            Console.WriteLine(decision);

        }
    }
}
