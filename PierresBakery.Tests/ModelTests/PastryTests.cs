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
      Pastry newPastry = new Pastry(numOfPastry);
      int numOfPastryResult = newPastry.NumOfPastry;
      Assert.AreEqual(numOfPastry, numOfPastryResult);
    }

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

    [TestMethod]
    public void PastryPriceTotalMixedDeal_ReturnsPastryPriceTotalWithPartialDeal_Int()
    {
      int numOfPastry = 13;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = (((numOfPastry - (numOfPastry % 3)) / 3) * 5) + ((numOfPastry % 3) * 2);
      Assert.AreEqual(22, pastryResult);
    }

  }
}