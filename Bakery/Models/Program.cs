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
      Pastry pastry = new Pastry();

      Console.WriteLine("Welcome to our famous family owned bakery!");
      Console.WriteLine("Here are today's deals:");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Bread: $5.00. Every third loaf is free!");
      Console.WriteLine("Pastries. Buy one for $2.00, or three for $5.00!");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("How many loaves would you like?");
      string userInput = Console.ReadLine();
      int breadTotal = int.Parse(userInput);
      Console.WriteLine("How many Pastries would you like?");
      string userInput2 = Console.ReadLine();
      int pastryTotal = int.Parse(userInput2);
      Console.WriteLine("The total cost of " + userInput + " loaves is $" + bread.calculateLoafCost(breadTotal) + "and the total cost of " + userInput2 + " pastries is $" + pastry.calculatePastryCost(pastryTotal) + ".");
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

