using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class FreshBread
  {
    public string Bread {get; set; }
    // private static Order<FreshBread> _instances = new Order<FreshBread> {};

    public FreshBread(int bread)
    {
      Bread = bread.ToString();
    }
  //   public static int BreadPrice(string userInput)
  //   {
  //     if (userInput = bread)
  //     {
  //     int price = 5;
  //     string finalPrice = price.ToString();
  //     return finalPrice;
  //     }
  //   }
  } 
}