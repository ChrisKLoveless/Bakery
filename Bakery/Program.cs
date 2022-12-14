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
      Console.WriteLine("[Get 3 for $5!] \n");
      StartOrder();

      static void ErrorRestart()
      {
        Console.WriteLine("Sorry that response was not valid please try again.");
            StartOrder();
      }

      static void StartOrder()
      {
        Console.WriteLine("Would you like to place an Order? [Y/y for YES; Press Enter for NO]");
        string orderResponse = Console.ReadLine().ToUpper();
        if (orderResponse == "Y" || orderResponse == "YES")
        {
          try
          {
            int cost = 0;
            Console.WriteLine("\n How many Loaves of Bread? : ");
            int loafCount = int.Parse(Console.ReadLine());
            Bread loaf = new Bread(loafCount);
            if(loaf.Count < 0)
            {
              ErrorRestart();
            }

            Console.WriteLine("\n How many Yummy Pastries? : ");
            int pastryCount = int.Parse(Console.ReadLine());
            Pastry cake = new Pastry(pastryCount);
            if(cake.Count < 0)
            {
              ErrorRestart();
            }
        
            cost = (loaf.OrderPrice()) + (cake.OrderPrice());
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
          catch
          {
            ErrorRestart();
          }
        }
        else if(orderResponse == "" || orderResponse == "N" || orderResponse == "NO" || orderResponse == "E" || orderResponse == "EXIT")
        {
          Environment.Exit(1);
        }
        else
        {
          ErrorRestart();
        } 
      }
    }
  }
}