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
    public void GetNumberOfPastry_ReturnsNumberOfPastries_Int()
    {
      int numOfPastry = 1;
      Pastry newPastry = new Pastry(numOfPastry);
      int numOfPastryResult = newPastry.NumOfPastry;
      Assert.AreEqual(numOfPastry, numOfPastryResult);
    }

  }
}