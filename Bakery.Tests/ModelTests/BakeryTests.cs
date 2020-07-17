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
      Bread bread1 = new Bread(1);
      Assert.AreEqual(typeof(Bread), bread1.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastry1 = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastry1.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order order1 = new Order(1, 1);
      Assert.AreEqual(typeof(Order), order1.GetType());
    }

    [TestMethod]
    public void BreadTotal_CalculatesTotalBreadCost_10()
    {
      Bread bread1 = new Bread(2);
      Assert.AreEqual(10, bread1.BreadTotal());
    }

    [TestMethod]
    public void PastryTotal_CalculatesTotalPastryCost_4()
    {
      Pastry pastry1 = new Pastry(2);
      Assert.AreEqual(4, pastry1.PastryTotal());
    }

    [TestMethod]
    public void BreadTotal_CalculatesTotalBreadCostWithDeals_15()
    {
      Bread bread1 = new Bread(4);
      Assert.AreEqual(15, bread1.BreadTotal());
    }

    [TestMethod]
    public void PastryTotal_CalculatesTotalPastryCostWithDeals_9()
    {
      Pastry pastry1 = new Pastry(5);
      Assert.AreEqual(9, pastry1.PastryTotal());
    }

    [TestMethod]
    public void OrderConstructor_PassesBreadTotalsAsParameter_10()
    {
      Bread bread1 = new Bread(3);
      Order order1 = new Order(bread1.BreadTotal(), 1);
      Assert.AreEqual(10, order1.AllBread);
    }

    [TestMethod]
    public void OrderTotal_AddsParametersTogether_11()
    {
      Order order1 = new Order(5,6);
      Assert.AreEqual(11, order1.OrderTotal());
    }
  }
}