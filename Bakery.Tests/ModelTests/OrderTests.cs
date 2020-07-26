using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests
  {

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order order1 = new Order(1, 1);
      Assert.AreEqual(typeof(Order), order1.GetType());
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