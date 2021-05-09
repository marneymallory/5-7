using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.TestTools
{
  [TestClass]
  public class BreadTests : IDisposable
  {
    public void Dispose()
    {
      Bread.ClearAll();
    }
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int amount = 1;
      Bread newBread = new Bread(amount);
      int result = newBread.GetPrice();
      Assert.AreEqual(5, result);
    }
    [TestMethod]
    public void GetPrice_ReturnDeal_Int()
    {
      int amount = 4;
      Bread newBread = new Bread(amount);
      int result = newBread.GetPrice();
      Assert.AreEqual(15, result);
    }

  }
}