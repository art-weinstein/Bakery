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
      int breadCost = int.Parse(userInput);
      int breadTotal = bread.calculateLoafCost(breadCost);
      Console.WriteLine("How many Pastries would you like?");
      string userInput2 = Console.ReadLine();
      int pastryCost = int.Parse(userInput2);
      int pastryTotal = pastry.calculatePastryCost(pastryCost);
      Console.WriteLine("The cost of " + userInput + " loaves is $" + breadTotal + " and the cost of " + userInput2 + " pastries is $" + pastryTotal + ".");
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Your grand total is $" + (breadTotal + pastryTotal) + ". Thank you!");
    }
  }
}