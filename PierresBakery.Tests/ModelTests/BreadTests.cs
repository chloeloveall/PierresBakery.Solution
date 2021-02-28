using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetNumberOfBread_ReturnsNumberOfBread_Int()
    {
      int numOfBread = 1;
      Bread newBread = new Bread(numOfBread);
      int numOfBreadResult = newBread.NumOfBread;
      Assert.AreEqual(numOfBread, numOfBreadResult);
    }

    [TestMethod]
    public void BreadPriceTotal_ReturnsBreadPriceTotal_Int()
    {
      int numOfBread = 2;
      Bread newBread = new Bread(numOfBread);
      int breadResult = (numOfBread * 5);
      Assert.AreEqual(10, breadResult);
    }

    [TestMethod]
    public void BreadPriceTotalDeal_ReturnsBreadPriceTotalWithDeal_Int()
    {
      int numOfBread = 9;
      Bread newBread = new Bread(numOfBread);
      int breadResult = ((numOfBread / 3) * 10);
      Assert.AreEqual(30, breadResult);
    }

  }
}