using System;

namespace SimpleLoopExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            int gallons = 10;
            double litres;

            Console.WriteLine("Gallons | Litres");
            Console.WriteLine("--------|---------");

            //do
            //{
            //    litres = gallons * 3.785;
                
            //    Console.WriteLine($"   {gallons, -2}   |  {Convert.ToDecimal(litres), 3}");
            //    gallons++;
            //} while (gallons < 21);

            //while (gallons < 21)
            //{
            //    litres = gallons * 3.785;

            //    Console.WriteLine($"   {gallons,-2}   |  {Convert.ToDecimal(litres),3}");
            //    gallons++;
            //}

            for (int i = 10; i < 21; i++)
            {
                litres = gallons * 3.785;

                Console.WriteLine($"   {gallons,-2}   |  {Convert.ToDecimal(litres),3}");
                gallons++;
            }
        }
    }
}
