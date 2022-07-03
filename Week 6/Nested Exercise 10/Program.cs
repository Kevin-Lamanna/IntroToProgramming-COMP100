using System;

namespace Nested_Exercise_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            double length, width, area;

            Console.WriteLine("Enter the length of your lawn: ");
            length = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width of your lawn: ");
            width = Double.Parse(Console.ReadLine());

            // Processing
            double weeklyFee;
            double totalFee;
            area = length * width;

            if ((area >= 400) && (area < 600))
            {
                weeklyFee = 35;
            }
            else if (area >= 600)
            {
                weeklyFee = 50;
            }
            else
            {
                weeklyFee = 25;
            }    

            // Output
            totalFee = 20 * weeklyFee;
            Console.WriteLine($"Weekly Fee: {weeklyFee:C}  Total Fee: {totalFee:C}");


            // Input
            int payments;
            double costPerPayment;

            Console.WriteLine("Enter the number corresponding to how would you like to pay for this service: (1) one payment, (2) Two payments, or (3) 20 payments");
            payments = int.Parse(Console.ReadLine());

            // Processing + Output
            double seasonTotal;

            switch(payments)
            {
                case 1:
                    seasonTotal = totalFee;
                    costPerPayment = totalFee;
                    Console.WriteLine($"Number of payments: 1  Amount per payment: {costPerPayment:C}  Season Total: {seasonTotal:C}");
                    break;
                case 2:
                    costPerPayment = (totalFee / 2) + 5;
                    seasonTotal = costPerPayment * 2;
                    Console.WriteLine($"Number of payments: 2  Amount per payment: {costPerPayment:C}  Season Total: {seasonTotal:C}");
                    break;
                case 3:
                    costPerPayment = (totalFee / 20) + 3;
                    seasonTotal = costPerPayment * 20;
                    Console.WriteLine($"Number of payments: 20  Amount per payment: {costPerPayment:C}  Season Total: {seasonTotal:C}");
                    break;
                default:
                    Console.WriteLine("Error: Invalid option entered");
                    break;
            }
        }
    }
}
