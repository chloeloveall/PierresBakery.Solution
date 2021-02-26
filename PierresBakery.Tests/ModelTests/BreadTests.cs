using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System;
using System.Collections.Generic;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests : IDisposable
  {

    public void Dispose()
    {
      Bread.ClearAll();
    }
    
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadPrice_ReturnsBreadPrice_Int()
    {
      int loaf = 5;
      Bread newBread = new Bread(loaf);
      int loafPriceResult = newBread.Loaf;
      Assert.AreEqual(loaf, loafPriceResult);
    }

    [TestMethod]
    public void SetBreadPrice_SetBreadPrice_Int()
    {
      int loaf = 5;
      Bread newBread = new Bread(loaf);

      int updatedLoaf = loaf * 2;
      newBread.Loaf = updatedLoaf;
      int loafPriceResult = newBread.Loaf;

      Assert.AreEqual(updatedLoaf, loafPriceResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_BreadList()
    {
      List<Bread> newBreadList = new List<Bread> { };

      List<Bread> result = Bread.GetAll();

      CollectionAssert.AreEqual(newBreadList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsBreads_BreadList()
    {
      int loafOne = 5;
      int loafTwo = 5;
      Bread newBreadOne = new Bread(loafOne);
      Bread newBreadTwo = new Bread(loafTwo);
      List<Bread> newBreadList = new List<Bread> { newBreadOne, newBreadTwo };

      List<Bread> result = Bread.GetAll();

      CollectionAssert.AreEqual(newBreadList, result);
    }

  }
}