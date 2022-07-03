// Program compares your name to the name of your boss

using System;

class DebugTwo1
{
  static void Main(string[] args)
  {
    string name, bossName;
    bool areNamesTheSame;
    
    Console.WriteLine("Enter your name: ");
    name = Console.ReadLine();
    Console.WriteLine("Hello {0}! Enter the name of your boss", name);
    bossName = Console.ReadLine();
    
    areNamesTheSame = (name == bossName);
    Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);
   }
}
