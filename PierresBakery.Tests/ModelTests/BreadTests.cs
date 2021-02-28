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
      int numOfBread = 1;
      Bread newBread = new Bread(numOfBread);
      int breadResult = (numOfBread * 5);
      Assert.AreEqual(5, breadResult);
    }










  //   [TestMethod]
  //   public void GetNumberOfLoaves_ReturnsNumberOfLoaves_Int()
  //   {
  //     int numOfLoaves = 1;
  //     Bread newBread = new Bread(numOfLoaves);
  //     int numOfLoavesResult = newBread.NumOfLoaves;
  //     Assert.AreEqual(numOfLoaves, numOfLoavesResult);
  //   }

  //   [TestMethod]
  //   public void GetBreadPrice_ReturnsBreadPrice_Int()
  //   {
  //     int loavesPrice = 5;
  //     Bread newBread = new Bread(loavesPrice);
  //     int loavesPriceResult = newBread.LoavesPrice;
  //     Assert.AreEqual(loavesPrice, loavesPriceResult);
  //   }

  //   [TestMethod]
  //   public void SetBreadPrice_SetBreadPrice_Int()
  //   {
  //     int loavesPrice = 5;
  //     Bread newBread = new Bread(loavesPrice);

  //     int updatedLoavesPrice = loavesPrice * 2;
  //     newBread.LoavesPrice = updatedLoavesPrice;
  //     int loavesPriceResult = newBread.LoavesPrice;

  //     Assert.AreEqual(updatedLoavesPrice, loavesPriceResult);
  //   }

  //   [TestMethod]
  //   public void GetAll_ReturnsEmptyList_BreadList()
  //   {
  //     List<Bread> newBreadList = new List<Bread> { };

  //     List<Bread> result = Bread.GetAll();

  //     CollectionAssert.AreEqual(newBreadList, result);
  //   }

  //   [TestMethod]
  //   public void GetAll_ReturnsBreads_BreadList()
  //   {
  //     int loafOne = 5;
  //     int loafTwo = 5;
  //     Bread newBreadOne = new Bread(loafOne);
  //     Bread newBreadTwo = new Bread(loafTwo);
  //     List<Bread> newBreadList = new List<Bread> { newBreadOne, newBreadTwo };

  //     List<Bread> result = Bread.GetAll();

  //     CollectionAssert.AreEqual(newBreadList, result);
  //   }

  }
}