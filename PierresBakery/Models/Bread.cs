using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Loaf { get; set; }

    public Bread(int loaf)
    {
      Loaf = loaf;
    }
  }
}