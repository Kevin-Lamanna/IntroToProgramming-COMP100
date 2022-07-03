using System;

namespace LabExercise12
{
    class Program
    {
        static void Main(string[] args)
        {
         //Input
         double length;
         double width;

         Console.Write("Enter the length of your lawn: ");
            length = double.Parse(Console.ReadLine());
         Console.Write("Enter the width of your lawn: ");
            width = double.Parse(Console.ReadLine());

         //Processing
         double area = length*width;
         double weeklyFee;

         if (area < 400)
            {
             weeklyFee = 25;
            }
         else if (area > 400 & area < 600)
            {
                weeklyFee = 35;
            }
         else
            {
                weeklyFee = 50;
            }


         //Output
         double totalLawnFee = 20*weeklyFee;

         Console.WriteLine($"Your weekly mowing fee is ${weeklyFee} and your total mowing fee is ${totalLawnFee}");

         Console.WriteLine();
         Console.WriteLine();

            int paymentChoice;
         double paymentAmount;
         double seasonTotal;
         Console.Write("Choose a payment option: (1) One payment, (2) Two payments, or (3) 20 weekly payments: ");
         paymentChoice = int.Parse(Console.ReadLine());
        
         if (paymentChoice == 1)
            {
                paymentAmount = totalLawnFee;
                Console.WriteLine($"Your season total is one payment of ${paymentAmount}");
            }
         else if (paymentChoice == 2)
            {
                paymentAmount = totalLawnFee/2 + 5;
                Console.WriteLine($"You must make two payments. Each payment is ${paymentAmount}. Your season total is ${totalLawnFee}");
          
            }
         else if (paymentChoice == 3)
            {
                paymentAmount = totalLawnFee / 20 + 3;
                Console.WriteLine($"You must make twenty payments. Each payment is ${paymentAmount}. Your season total is ${totalLawnFee}");
            }
         Console.WriteLine();
         Console.WriteLine();

        }
    }
}
