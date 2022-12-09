using System;
using Bakery;

namespace Bakery.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("\n Welcome to Pierre's Bakery!");
      Console.WriteLine("Menu: \n");
      Console.WriteLine("Loaf of Bread.....$5");
      Console.WriteLine("[Buy 2 get 1 Free!] \n");
      Console.WriteLine("A Yummy Pastry.....$2");
      Console.WriteLine("[Every 3rd Pastry if Half Price!] \n");
      Console.WriteLine("Would you like to place an Order? [Y/y for YES; Press Enter for NO]");

      string orderResponse = Console.ReadLine().ToUpper();
      if (orderResponse == "Y")
      {
        Console.WriteLine("\n How many Loaves of Bread? : ");
        int loafCount = int.Parse(Console.ReadLine());
        Console.WriteLine("\n How many Yummy Pastries? : ");
        int pastryCount = int.Parse(Console.ReadLine());
        Console.WriteLine($"Bread Count: {loafCount}  Pastry Count: {pastryCount}");

        
      }
    }
  }
}