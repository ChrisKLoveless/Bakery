using System;
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
        Pastry cake = new Pastry();
        Assert.AreEqual(typeof(Pastry), cake.GetType());
      }
  }
}

