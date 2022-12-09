using System;
using Bakery.Models;

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
      StartOrder();

      static void StartOrder()
      {
        Console.WriteLine("Would you like to place an Order? [Y/y for YES; Press Enter for NO]");
        string orderResponse = Console.ReadLine().ToUpper();
          if (orderResponse == "Y")
          {
            int cost = 0;
            Console.WriteLine("\n How many Loaves of Bread? : ");
            int loafCount = int.Parse(Console.ReadLine());
            Console.WriteLine("\n How many Yummy Pastries? : ");
            int pastryCount = int.Parse(Console.ReadLine());

            Bread loaf = new Bread(loafCount);
            Pastry cake = new Pastry(pastryCount);
            cost = (loaf.Count * loaf.Price) + (cake.Count * cake.Price);

            if(loaf.Count % 3 == 0)
            {
              cost -= (loaf.Count/3) * 5;
            }

            if(cake.Count % 3 == 0)
            {
              cost -= (cake.Count/3);
            }

            Console.WriteLine("\n Your Order includes:");
            Console.WriteLine($"Bread Count: {loafCount}  Pastry Count: {pastryCount}");
            Console.WriteLine($"\n Your Total is: ${cost}");
            Console.WriteLine("Please enter Your Total Cost to Pay: ");

            int costResponse = int.Parse(Console.ReadLine());

            if(costResponse == cost)
            {
              Console.WriteLine("Thank you for your business!");
            }
            else if(costResponse > cost)
            {
              Console.WriteLine("WOW a Tip! Thank you for your business!");
            }
            else
            {
              Console.WriteLine("Is this a robbery?");
            }
          }
          else{
            Console.WriteLine("Sorry that response was not valid please try again.");
            StartOrder();
          }
      }
      
    }
  }
}