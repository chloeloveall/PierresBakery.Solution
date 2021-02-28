using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastry { get; }
    // public int PriceOfPastry { get; }
    // , int priceOfPastry

    public Pastry(int numOfPastry)
    {
      NumOfPastry = numOfPastry;
      // PriceOfPastry = priceOfPastry;
    }

    public int PastryPriceTotal(int numOfPastry)
    {
      if (numOfPastry % 3 == 0)
      {
        int pastryResult = ((numOfPastry / 3) * 5);
        return pastryResult;
      }
      else
      {
        // int pastryResult = (numOfPastry * 2);
        return numOfPastry;
      }
    }
  }
}