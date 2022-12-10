using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
      public void BreadConstructor_CreatesInstanceOfBread_Bread()
      {
        Bread loaf = new Bread(1);
        Assert.AreEqual(typeof(Bread), loaf.GetType());
      }

    [TestMethod]
      public void BreadConstructor_ReturnsCountOfBread_Count()
      {
        int count = 1;
        Bread loaf = new Bread(count);
        Assert.AreEqual(count, loaf.Count);
      }

    [TestMethod]
      public void BreadConstructor_ReturnsPriceOfBread_Price()
      {
        int price = 5;
        Bread loaf = new Bread(1);
        Assert.AreEqual(price, loaf.Price);
      }
  }

  [TestClass]
  public class PastryTests
  {
    [TestMethod]
      public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
      {
        Pastry cake = new Pastry(1);
        Assert.AreEqual(typeof(Pastry), cake.GetType());
      }

    [TestMethod]
      public void PastryConstructor_ReturnsCountOfPastry_Count()
      {
        int count = 1;
        Pastry cake = new Pastry(count);
        Assert.AreEqual(count, cake.Count);
      }

    [TestMethod]
      public void PastryConstructor_ReturnsPriceOfPastry_Price()
      {
        int price = 2;
        Pastry cake = new Pastry(1);
        Assert.AreEqual(price, cake.Price);
      }   

    [TestMethod]
      public void OrderPrice_ReturnsPriceOfPastryOrder_Int()
      {
        int order = 2;
        Pastry cake = new Pastry(1);
        int orderPrice = cake.OrderPrice();
        Assert.AreEqual(order, orderPrice);
      }   
  }
}

