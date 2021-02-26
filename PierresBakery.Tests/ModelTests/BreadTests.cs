using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    
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

  }
}