using System;

namespace LabExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double payRate;
         double hoursWorked;
         
         Console.WriteLine("Enter your pay rate: ");
         payRate = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Enter your hours worked: ");
         hoursWorked = Convert.ToDouble(Console.ReadLine());

         //Processing
         double gross;
         double withholding;
         gross = payRate * hoursWorked;

         if (gross > 300.00)
            {
                withholding = 0.12;
            }
         else
            {
                withholding = 0.10;
            }


         //Output
         double net;
         net = gross - gross*withholding;
         Console.WriteLine($"Your net pay is ${net}");
         
        }
    }
}
