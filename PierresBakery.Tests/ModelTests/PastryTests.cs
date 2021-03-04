using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

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
      int numOfPastry = 11;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = newPastry.PastryPriceTotal();
      Assert.AreEqual(19, pastryResult);
    }

    [TestMethod]
    public void PastryPriceTotalNoDeal_ReturnsPastryPriceTotalWithoutDeal_Int()
    {
      int numOfPastry = 2;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = newPastry.PastryPriceTotal();
      Assert.AreEqual(4, pastryResult);
    }

    [TestMethod]
    public void PastryPriceTotalMixedDeal_ReturnsPastryPriceTotalWithPartialDeal_Int()
    {
      int numOfPastry = 13;
      Pastry newPastry = new Pastry(numOfPastry);
      int pastryResult = newPastry.PastryPriceTotal();
      Assert.AreEqual(22, pastryResult);
    }

  }
}