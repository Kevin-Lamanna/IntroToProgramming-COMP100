using System;

namespace Hens
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            //int h1, h2, h3, h4;

            int hen1;
            int hen2;
            int hen3;
            int hen4;

            Console.Write("How many eggs for hen#1? "); //blink at the end of the line
            hen1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many eggs for hen#2? ");
            hen2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many eggs for hen#3? ");
            hen3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many eggs for hen#4? ");
            hen4 = Convert.ToInt32(Console.ReadLine());

            //Process
            int totalOfEggs;

            totalOfEggs = hen1 + hen2 + hen3 + hen4;

            int dozens;
            int leftOver;

            dozens = totalOfEggs / 12; //Returns the number of dozens without the leftover
            leftOver = totalOfEggs % 12;
            //leftOver = totalOfEggs - (dozens*12);

            //Output

            Console.WriteLine("A total of " + totalOfEggs + " eggs is " + dozens + " dozen(s) and " + leftOver + " eggs");
            Console.WriteLine($"A total of {totalOfEggs} eggs is {dozens} dozen(s) and {leftOver} eggs");
        }
    }
}
