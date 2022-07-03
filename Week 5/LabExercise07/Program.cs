using System;

namespace LabExercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double textbookCost = 125;
            double hardPremium;
            double discount;
            int numOfHardTexts;
            int numOfSoftTexts;
            Console.WriteLine("How many Hardcover textbooks are you buying?: ");
            numOfHardTexts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many Softcover textbooks are you buying?: ");
            numOfSoftTexts = Convert.ToInt32(Console.ReadLine());


            //Processing
            double totalPrice;
            int totalBooks;
            double hardTotal;
            double softTotal;

            totalBooks = numOfHardTexts + numOfSoftTexts;
            hardPremium = numOfHardTexts * textbookCost * 0.20;
            hardTotal = numOfHardTexts * textbookCost + hardPremium;
            softTotal = numOfSoftTexts * textbookCost;
            discount = (hardTotal + softTotal) * 0.05;

            if (totalBooks > 4)
            {
                totalPrice = (hardTotal + softTotal) - discount;
            }
            else
            {
                totalPrice = (hardTotal + softTotal);
            }


         //Output

         Console.WriteLine($"Your subtotal is ${totalPrice}");
         
        }
    }
}
