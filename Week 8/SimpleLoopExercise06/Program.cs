using System;

namespace SimpleLoopExercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int square;
            int cube;

            Console.WriteLine(" Number | Square | Cube");
            Console.WriteLine("--------|--------|-------");

            //do
            //{
            //    square = num * num;
            //    cube = num * num * num;

            //    Console.WriteLine($"   {num, -2}   |  {square, -3}   |  {cube, -4}");
            //    num++;
            //} while (num <= 20);

            //while (num <= 20)
            //{
            //    square = num * num;
            //    cube = num * num * num;

            //    Console.WriteLine($"   {num, -2}   |  {square, -3}   |  {cube, -4}");
            //    num++;
            //}

            for (int i = 0; i <= 20; i++)
            {
                   square = num * num;
                   cube = num *num*num;

                    Console.WriteLine($"   {num, -2}   |  {square, -3}   |  {cube, -4}");
                    num++;
            }
            // For two decimal places { myVariable:N2}
        }
    }
}
