namespace Bakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Count { get; set; }

    public Pastry(int count)
    {
      Price = 2;
      Count = count;
    }
  }
}