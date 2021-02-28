using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastry;
    public int PriceOfPastry;

    public Pastry(int numOfPastry, int priceOfPastry)
    {
      NumOfPastry = numOfPastry;
      PriceOfPastry = priceOfPastry;
    }
  }
}