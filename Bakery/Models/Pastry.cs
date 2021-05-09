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
      return (Amount * 2 - (5/3)) ;
    }
    
  }

}