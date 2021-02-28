using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumOfBread { get; }

    public Bread(int numOfBread)
    {
      NumOfBread = numOfBread;
    }

    public int BreadPriceTotal(int numOfBread)
    {
      if (numOfBread < 3)
      {
        int breadResult = (numOfBread * 5);
        return breadResult;
      }
      else
      {
        int breadResult = ((numOfBread / 3) * 10);
        return breadResult;
      }
    }

  }
}