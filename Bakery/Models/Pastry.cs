using System;
using System.Collections.Generic;

namespace Bakery.Models 
{ 
  public class Pastry
  {
    public int Amount { get; set; }

    private static List<Pastry> _instances = new List<Pastry> { };
    public static List<Pastry> GetAll()
    {
      return _instances;
    }
     public Pastry(int amount)
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
      int PastryPrice = 2;
      int TotalCost = 0;
      // 8 * 2 = 16
      // 16 - (8/3) = 14 (saving $2)
      // 10 % 3 = 1
      TotalCost = (Amount * PastryPrice);
      TotalCost -= (Amount/3); 
      return TotalCost;
      // WIP, still working on this formula
      // could create public int ApplyDiscount()
    }
    
  }

}