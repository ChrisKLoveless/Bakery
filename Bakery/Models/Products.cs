using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public Bread(int count)
    {
      Price = 5;
      Count = count;
    }
  }

  public class Pastry
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public Pastry(int count)
    {
      // Price = 2;
      Count = count;
    }

  }
}