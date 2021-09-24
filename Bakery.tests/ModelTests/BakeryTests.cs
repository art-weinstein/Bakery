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
      FreshBread newFreshBread = new FreshBread("This");
      Assert.AreEqual(typeof(FreshBread), newFreshBread.GetType());
    }
  }
}