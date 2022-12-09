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
      public void BreadConstructor_ReturnsCountOfOrder_Count()
      {
        int count = 1;
        Bread loaf = new Bread(count);
        Assert.AreEqual(count, loaf.Count);
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

