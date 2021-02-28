using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1, 2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetNumberOfPastry_ReturnsNumberOfPastry_Int()
    {
      int numOfPastry = 1;
      int priceOfPastry = 2;
      Pastry newPastry = new Pastry(numOfPastry, priceOfPastry);
      int numOfPastryResult = newPastry.NumOfPastry;
      Assert.AreEqual(numOfPastry, numOfPastryResult);
    }

    [TestMethod]
    public void GetPriceOfPastry_ReturnsPriceOfPastry_Int()
    {
      int numOfPastry = 1;
      int priceOfPastry = 2;
      Pastry newPastry = new Pastry(numOfPastry, priceOfPastry);
      int priceOfPastryResult = newPastry.PriceOfPastry;
      Assert.AreEqual(priceOfPastry, priceOfPastryResult);
    }

  }
}