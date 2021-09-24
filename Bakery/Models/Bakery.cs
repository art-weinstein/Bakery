using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models
{
  public class FreshBread
  {
    public static int BreadPrice { get; set; }
    public static int BreadAmount { get; set; }
    public static int BreadTotal { get; set; }

    public static void BreadCost(int loaves)
    {
      BreadAmount = loaves;
      BreadPrice = loaves * 5;

      if (BreadAmount >= 3)
      {
        int GroupedLoaves = (loaves / 3);
        int IndividualLoaves = (loaves % 3);
        BreadPrice = (GroupedLoaves * 10) + (IndividualLoaves * 5);
      }
      }
  }
}

