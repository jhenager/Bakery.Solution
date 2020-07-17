using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstanceOfBread_Bread()
    {
      Bread bread1 = new Bread();
      Assert.AreEqual(typeof(Bread), bread1.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastry1 = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry1.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order order1 = new Order();
      Assert.AreEqual(typeof(Order), order1.GetType());
    }

    [TestMethod]

    public void BreadTotal_CalculatesTotalBreadCost_10()
    {
      Bread bread1 = new Bread(2);
      Assert.AreEqual(10, bread1.BreadTotal());
    }
  }
}