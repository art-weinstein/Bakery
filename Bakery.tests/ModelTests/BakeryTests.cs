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
    public void FreshBreadConstructor_CreatesInstanceOfFreshBread_FreshBread()
    {
      FreshBread newFreshBread = new FreshBread();
      Assert.AreEqual(typeof(FreshBread), newFreshBread.GetType());
    }
    [TestMethod]
    public void FreshBreadPriceCheck_CalculateBreadCost_FreshBread()
    {
      FreshBread newFreshBread = new FreshBread();
      int loaves = 2;
      FreshBread.BreadCost(loaves);
      // FreshBread.BreadCost(loaves);
      Assert.AreEqual(10, FreshBread.BreadCost(loaves));

    }
  }
}