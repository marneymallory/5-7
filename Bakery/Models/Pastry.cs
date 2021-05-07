using System;
using System.Collections.Generic;

namespace Bakery.Models 
{ 
  public class Pastry
  {
    public int Amount { get; set; }
    public int Price { get; set; }
    private static List<Pastry> _instances = new List<Pastry> { };
    public static List<Pastry> GetAll()
    {
      return _instances;
    } 
     public static void ClearAll()
    {
      _instances.Clear();
    }
  }

}