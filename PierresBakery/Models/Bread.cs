using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }

    private static List<Bread> _loaves = new List<Bread> {};
    public static void ClearAll()
    {
      _loaves.Clear();
    }

    public static List<Bread> GetAll()
    {
      return _loaves;
    }

    public Bread(int loaf)
    {
      Loaf = loaf;
      _loaves.Add(this);
    }
  }
}