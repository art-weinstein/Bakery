using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      Bread bread = new Bread();
      // BreadTotal();
      Console.WriteLine("Welcome to our famous family owned bakery!");
      Console.WriteLine("Place your order here!");
      string userInput = Console.ReadLine();
      int breadTotal = int.Parse(userInput);
      bread.calculateLoafCost(breadTotal);
      Console.WriteLine(bread.BreadPrice);
    }
  }
}


//   public static void BreadTotal()
//     {
//       Console.WriteLine("Welcome to our famous family owned bakery!");
//       Console.WriteLine("Place your order here!");
//       string userInput = Console.ReadLine();
//       int breadTotal = int.Parse(userInput);
//       // int breadTotalToInt = int.Parse(breadTotal);
//       FreshBread.BreadCost(breadTotal);
//       // FreshBread order = new FreshBread(userInput); 
//       // int breadTotal = int.Parse(userInput);
//       // string output = FreshBread.BreadCost(userInput);

//       System.Console.WriteLine(breadTotal);
//     }
//   }
// }

//  public static void BreadTotal()
//     {
//       Console.WriteLine("Welcome to our famous family owned bakery!");
//       Console.WriteLine("Place your order here!");
//       string userInput = Console.ReadLine();
//       int breadTotal = int.Parse(userInput);
//       FreshBread.BreadCost(breadTotal);
//       Console.WriteLine(FreshBread.BreadPrice);
//     }
//   }
// }

