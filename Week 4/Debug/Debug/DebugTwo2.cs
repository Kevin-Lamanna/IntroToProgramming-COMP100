// This program greets the user
// and multiplies two entered values

using System;

class DebugTwo2
{
   static void Main(string[] args)
   {
      string name;
      int first, second, product;
      
      Console.WriteLine("Enter your name: ");
      name = Console.ReadLine();
      Console.WriteLine("Hello {0}! Enter an integer: ", name);
      first = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Enter another integer: ");
      second = Convert.ToInt32(Console.ReadLine());

      product = first * second;
      Console.WriteLine("Thank you {0}. The product of {1} and {2} is {3}",
	      name, first, second, product);
   }
}
