using System;

namespace Switch_Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            string hst;
            string prov;

            Console.WriteLine("Enter your province code: ");
            prov = Console.ReadLine();

            switch(prov)
            { 
                case "ON": 
                case "NB":
                case "NL":
                case "NS":
                case "BC":
                    hst = "Exists";
                    Console.WriteLine(hst);
                    break;
                case "MB":
                case "QC":
                case "PE":
                case "SK":
                case "AB":
                case "YT":
                case "NT":
                case "NV":
                    hst = "Does not exist";
                    Console.WriteLine(hst);
                    break;
                default:
                    Console.WriteLine("Not a valid province code");
                    break;
            }
        }
    }
}
