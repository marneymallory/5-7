using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System;
using System.Collections.Generic;

namespace Bakery.TestTools
{
  [TestClass]
  public class PastryTests : IDisposable
  {
    public void Dispose()
    {
      Pastry.ClearAll();
    }
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void GetPrice_ReturnPrice_Int()
    {
      int amount = 1;
      Pastry newPastry = new Pastry(amount);
      int result = newPastry.GetPrice();
      Assert.AreEqual(2, result);
    } 
     [TestMethod]
    public void GetPrice_ReturnDeal_Int()
    {
      int amount = 3;
      Pastry newPastry = new Pastry(amount);
      int result = newPastry.GetPrice();
      Assert.AreEqual(5, result);
      
    }
  }
}