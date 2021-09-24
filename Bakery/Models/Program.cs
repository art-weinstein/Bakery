using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Models
{
  public class Program
  {
    public static void Main()
    {
      System.Console.WriteLine("Welcome to our famous family owned bakery!");
      System.Console.WriteLine("Place your order here!");
      string userInput = Console.ReadLine();
      int breadTotal = int.Parse(userInput);
      // string output = FreshBread.BreadPrice();

      // System.Console.WriteLine(output);
    }
  }
}
