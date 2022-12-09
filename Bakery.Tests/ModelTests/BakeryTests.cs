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
        Bread loaf = new Bread();
        Assert.AreEqual(typeof(Bread), loaf.GetType());
      }
  }
}
