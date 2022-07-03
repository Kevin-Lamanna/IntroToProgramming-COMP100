using System;

namespace ArraysExercise01
{
    class Program
    {
        // static char[5] vowels;    Saves an empty Array of length 5.
        // static variables belong to the class but not to the object of the class
        // we have to match static with the static of the Main method
        // Global means declared and initialized outside of the main method

        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };

        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        static string[] poem = { "Mary", "had", "a", "little", "lamb" };

        static string[] obama = { "Barack", "Hussein", "Obama" };
        static void Main(string[] args)
        {

            //QUESTION 1

            //for (int index = 0; index < obama.Length; index++)
            //{
            //    Console.WriteLine(obama[index]);
            //}

            //Console.ReadKey();

            //foreach (string word in obama)
            //{
            //    Console.WriteLine(word);
            //}

            //Console.ReadKey();

            //QUESTION 2

            //for (int index = (poem.Length - 1);  index >=0 ; index--)
            //{
            //    Console.WriteLine($"{poem[index]}");
            //}

            //Console.ReadKey();


            //Question 3
            //int sum = 0;

            //foreach (int number in primes)
            //{
            //    sum += number;
            //}
            //Console.WriteLine($" The sum is equal to {sum}");

            //Console.ReadKey();


            //QUESTION 4
            //foreach (int number in primes)
            //{
            //    Console.WriteLine(number*2);
            //}

            //Console.ReadKey();

            //for (int i = 0; i < primes.Length; i++)
            //{
            //    primes[i] *= 2;

            //    if (i == primes.Length - 1)
            //        Console.Write($"{primes[i]}");
            //    else
            //        Console.Write($"{primes[i]}, ");
            //}

            //Question 5

            //for (int index = 0; index <= (vowels.Length - 1); index++)    //Implicit conversion!
            //{
            //    vowels[index] = Convert.ToChar(vowels[index] - 32);       //Chars also have integer values; however, 
            //}                                                             //subtracting an int from a char produces an int 
            //Console.WriteLine(vowels);                                    //which needs to be converted back into a char.

            //Console.ReadKey();


            //for (int i = 0; i < vowels.Length; i++)
            //{
            //    vowels[i] = Convert.ToChar((int)vowels[i] - 32);
            //    if (i == primes.Length - 1)
            //        Console.Write($"{vowels[i]}");
            //    else
            //        Console.Write($"{vowels[i]}, ");
            //}

            //Console.ReadKey();


            //Question 6

            //foreach (int number in primes)
            //{
            //    if (number > 10)
            //        Console.WriteLine(number);
            //}

            //Console.ReadKey();

            //Question 7
            //int oddCount = 0;
            //int evenCount = 0;

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        evenCount++;
            //    else
            //        oddCount++;
            //}
            //Console.WriteLine($" Even number count: {evenCount}  Odd number count: {oddCount}");

            //Console.ReadKey();


            int counter = 0;
            int counterEven = 0;
            int counterOdd = 0;

            while (counter < numbers.Length)
            {
                if (numbers[counter] % 2 == 0)
                    counterEven++;
                else
                    counterOdd++;


                counter++;
            }

            Console.WriteLine($"Odd Counter: {counterOdd}");
            Console.WriteLine($"Even Counter: {counterEven}");
        }
    }
}
