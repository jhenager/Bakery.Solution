using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread bread1 = new Bread(1);
      Assert.AreEqual(typeof(Bread), bread1.GetType());
    }

    [TestMethod]
    public void BreadTotal_CalculatesTotalBreadCost_10()
    {
      Bread bread1 = new Bread(2);
      Assert.AreEqual(10, bread1.BreadTotal());
    }

    [TestMethod]
    public void BreadTotal_CalculatesTotalBreadCostWithDeals_15()
    {
      Bread bread1 = new Bread(4);
      Assert.AreEqual(15, bread1.BreadTotal());
    }
  }
}