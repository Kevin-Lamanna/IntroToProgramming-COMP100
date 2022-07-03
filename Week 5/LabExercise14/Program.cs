using System;

namespace LabExercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            const double ON = 0.14;
            const double PQ = 0.13;
            const double otherProv = 0;
            string userProv;
            double itemCost;

            Console.Write("Enter your 2-letter province code: ");
            userProv = Console.ReadLine();

            Console.Write("Enter the cost of your item: ");
            itemCost = Convert.ToDouble(Console.ReadLine());

            //Processing


            //Output
            double tax;
            if (userProv == "ON" || userProv == "NO")
            {
                tax = itemCost * ON;
            }
            else if (userProv == "PQ" || userProv == "QP")
            {
                tax = itemCost * PQ;
            }
            else
            {
                tax = itemCost * otherProv;
            }

            Console.WriteLine($"The tax on your item is {tax.ToString("C")}");
        }
    }
}
