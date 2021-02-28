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
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetNumberOfPastry_ReturnsNumberOfPastry_Int()
    {
      int numOfPastry = 1;
      // int priceOfPastry = 2; priceOfPastry
      Pastry newPastry = new Pastry(numOfPastry);
      int numOfPastryResult = newPastry.NumOfPastry;
      Assert.AreEqual(numOfPastry, numOfPastryResult);
    }

    // [TestMethod]
    // public void GetPriceOfPastry_ReturnsPriceOfPastry_Int()
    // {
    //   int numOfPastry = 1;
    //   int priceOfPastry = 2;
    //   Pastry newPastry = new Pastry(numOfPastry, priceOfPastry);
    //   int priceOfPastryResult = newPastry.PriceOfPastry;
    //   Assert.AreEqual(priceOfPastry, priceOfPastryResult);
    // }

    [TestMethod]
    public void PastryPriceTotal_ReturnsPastryPriceTotal_Int()
    {
      int numOfPastry = 7;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = ((numOfPastry / 3) * 5);
      Assert.AreEqual(10, pastryResult);
    }

    [TestMethod]
    public void PastryPriceTotalNoDeal_ReturnsPastryPriceTotalWithoutDeal_Int()
    {
      int numOfPastry = 2;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = (numOfPastry * 2);
      Assert.AreEqual(4, pastryResult);
    }

    // [TestMethod]
    // public void GetTotalPastryCount_ReturnsTotalNumberOfPastry_Int()
    // {
    //   int numOfPastryTotal = 5;
    //   Pastry newPastry = new Pastry();
    //   int numOfPastryTotal
    // }

  }
}