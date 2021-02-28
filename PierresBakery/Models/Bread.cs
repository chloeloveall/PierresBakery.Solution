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


    // public static void ClearAll()
    // {
    //   _loaves.Clear();
    // }

    // public static List<Bread> GetAll()
    // {
    //   return _loaves;
    // }

    // public Bread(int loaf)
    // {
    //   Loaf = loaf;
    //   _loaves.Add(this);
    // }
  }
}