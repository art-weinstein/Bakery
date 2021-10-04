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
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }
    [TestMethod]
    public void BreadPriceCheck_CalculateLoafCostWithoutDiscount_Bread()
    {
      Bread bread = new Bread();
      bread.BreadPrice = 5;
      Assert.AreEqual(5, bread.calculateLoafCost(1));
    }
    [TestMethod]
    public void BreadPriceCheck_CalculateLoafCost_Bread()
    {
      Bread bread = new Bread();
      bread.BreadPrice = 5;
      Assert.AreEqual(20, bread.calculateLoafCost(5));
    }
    [TestMethod]
    public void PastryPriceCheck_CalculatePastryCost_Pastry()
    {
      Pastry pastry = new Pastry();
      pastry.PastryPrice = 2;
      Assert.AreEqual(9, pastry.calculatePastryCost(5));
    }
  }
}