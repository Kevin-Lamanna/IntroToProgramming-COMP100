using System;

namespace ArrayExercise02
{
    class Program
    {
        


    
        static void Main(string[] args)
        {
            string[] names = "Dean Bart Luke Olaf Tess Sara Vida Sean Rita Hana Arya Curt Eden Fred Gina West Jack Kate Zuri Dave Toni Ruth Vera Brad Theo Xena Mark Neal Nick".Split();


            string[] pets = "dog cat gecko hamster chinchilla rabbit turtle snake newt hedgehog parrot buggie ferret gerbil mouse".Split();


            char[] letters = "dog cat hamster rabbit parrot buggie gerbil ".ToCharArray();


            //QUESTION 1

            Array.Reverse(names); //Reverses and updates the names Array

            for (int i = 0; i < names.Length; i++)
            {
                if (i == names.Length - 1)
                    Console.Write($"{names[i]}");
                else
                    Console.Write($"{names[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(names);

            for (int i = 0; i < names.Length; i++)
            {
                if (i == names.Length - 1)
                    Console.Write($"{names[i]}");
                else
                    Console.Write($"{names[i]} ");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(Array.BinarySearch(names, "Nick"));

            //QUESTION 2

            Console.WriteLine();
            Console.WriteLine();

            Array.Reverse(letters);

            for (int index = 0; index < letters.Length; index++)
            {
                if (index == letters.Length - 1)
                    Console.Write($"{letters[index]}");
                else
                    Console.Write($"{letters[index]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Array.Sort(letters);

            for (int index = 0; index < letters.Length; index++)
            {
                if (index == letters.Length - 1)
                    Console.Write($"{letters[index]}");
                else
                    Console.Write($"{letters[index]} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            
        
            //QUESTION 3  

            int numOfLetters = 4;

            string chars = "abcdefghijklmnopqrstuvwxyz";
            char[] stringChars = new char[4];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
                {
                  stringChars[i] = chars[random.Next(chars.Length)];
                }
            var finalString = new String(stringChars);
            Console.WriteLine(finalString);
        }
    }
}
