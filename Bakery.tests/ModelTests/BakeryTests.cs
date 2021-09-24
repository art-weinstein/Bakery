using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newFreshBread = new Bread();
      Assert.AreEqual(typeof(Bread), newFreshBread.GetType());
    }
    [TestMethod]
    public void BreadPriceCheck_CalculateLoafCost_FreshBread()
    {
      Bread bread = new Bread();
      bread.BreadPrice = 5;
      Assert.AreEqual(2, bread.calculateLoafCost(5));

    }
  }
}