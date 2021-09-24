using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class Bread
  {
    public int BreadPrice { get; set; }
    public int BreadAmount { get; set; }
    public int BreadTotal { get; set; }

    public int calculateLoafCost(int loaves)
    {
      // # this.BreadAmount = loaves;
      int loafPrice = loaves * 5;

      if (BreadAmount >= 3)
      {
        int GroupedLoaves = (loaves / 3);
        int IndividualLoaves = (loaves % 3);
        BreadPrice = (GroupedLoaves * 10) + (IndividualLoaves * 5);
      }
      return loafPrice;
      
      }
  }
}

