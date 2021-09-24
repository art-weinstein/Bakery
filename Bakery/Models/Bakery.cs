using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class FreshBread
  {

    public int Price { get; set; }
    public static List<FreshBread> _order = new List<FreshBread> {};
    
    public FreshBread(int price)
    {
      Price = 5;
      _order.Add(this);
    }
    public static List<FreshBread> GetAll()
    {
      return _order;
    }
  public static void ClearAll()
      {
        _order.Clear();
      }
  }
}
