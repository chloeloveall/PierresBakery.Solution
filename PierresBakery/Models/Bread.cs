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
      if (numOfBread < 2)
      {
        int breadResult = (numOfBread * 5);
        return breadResult;
      }
      else
      {
        return 0;
      }
    }
    
  }
}