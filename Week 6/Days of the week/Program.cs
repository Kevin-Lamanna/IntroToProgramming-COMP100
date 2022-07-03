using System;

namespace Days_of_the_week
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfTheWeek;
            string message;

            Console.WriteLine("Enter the day of the week: ");
            dayOfTheWeek = Console.ReadLine();


            switch (dayOfTheWeek.ToLower())  // Will work regardless of case sensitivity
            {
                case "wednesday":
                case "saturday":
                    message = "Home day";
                    break;
                case "sunday":
                case "monday":
                case "tuesday":
                case "thursday":
                case "friday":
                    message = "Work day";
                    break;
                default:
                    message = "Invalid day";
                    break;
            }

            Console.WriteLine(message);
        }
    }
}
