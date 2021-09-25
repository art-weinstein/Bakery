using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }

    public int calculateLoafCost(int loaves)
    {
      int loafPrice = loaves * 5;

      if (loaves >= 3)
      {
        int loafBundle = (loaves / 3);
        int singleLoaf = (loaves % 3);
        BreadPrice = (loafBundle * 10) + (singleLoaf * 5);
      }
      return BreadPrice;  
    }
  }
  public class Pastry
  {
    public int PastryPrice { get; set; }

    public int calculatePastryCost(int pastries){
      int pastryPrice = pastries *2;
      if (pastries >= 3)
      {
        int pastryBundle = (pastries / 3);
        int singlePastry = (pastries % 3);
        PastryPrice = (pastryBundle * 5) + (singlePastry * 2);
      }
      return PastryPrice;
    }
  }
}