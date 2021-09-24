using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class FreshBread
  {
    public string Bread {get; set; }
    // private static Order<FreshBread> _instances = new Order<FreshBread> {};

    public FreshBread(string bread)
    {
      Bread = bread;
    }
  } 
}