using System;
using System.Collections.Generic;

namespace Bakery.Models 
{ 
  public class Bread 
  {
    public int Amount { get; set; }
    private static List<Bread> _instances = new List<Bread> { };
    public static List<Bread> GetAll()
    {
      return _instances;
    }
     public Bread(int amount)
    {
      Amount = amount;
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public int GetPrice()
    {
      return Amount * 5;
    }
  }

}



