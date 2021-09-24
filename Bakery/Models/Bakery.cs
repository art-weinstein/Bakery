using System.Collections.Generic;
using Bakery.Models;
using System;


namespace Bakery.Models{
// {
  public class FreshBread
  {
//   {
//     public int BreadAmount {get; set; }
//     public int BreadTotal {get; set; }
//     public int BreadPrice { get; set; }
//     public static List<FreshBread> _order = new List<FreshBread> {};
    
//     public FreshBread(int breadTotal)
//     {
//       BreadTotal = breadTotal;
//       _order.Add(this);
//     }
//     public static List<FreshBread> GetAll()
//     {
//       return _order;
//     }
//   public static void ClearAll()
//       {
//         _order.Clear();
//       }
//   public int BreadCost(int breadAmount)
//     {
//     BreadAmount = breadAmount;  
//     BreadTotal = (breadAmount * 5);
//     return BreadTotal;
//     }
//   }
// }  {
    public static int BreadPrice { get; set; }
    public static int BreadAmount { get; set; }
    public static int BreadTotal { get; set; }

    public static void BreadCost(int loaves)
    {
      BreadAmount = loaves;
      BreadPrice = loaves * 5;
      }
    }
  }

