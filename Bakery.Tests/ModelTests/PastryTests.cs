using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;


namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreateInstanceOfPastry_Pastry()
    {
      Pastry pastry1 = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastry1.GetType());
    }


    [TestMethod]
    public void PastryTotal_CalculatesTotalPastryCost_4()
    {
      Pastry pastry1 = new Pastry(2);
      Assert.AreEqual(4, pastry1.PastryTotal());
    }

    [TestMethod]
    public void PastryTotal_CalculatesTotalPastryCostWithDeals_9()
    {
      Pastry pastry1 = new Pastry(5);
      Assert.AreEqual(9, pastry1.PastryTotal());
    }
  }
}