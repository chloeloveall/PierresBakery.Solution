namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumOfBread { get; }

    public Bread(int numOfBread)
    {
      NumOfBread = numOfBread;
    }

    public int BreadPriceTotal()
    {
      if (NumOfBread < 3)
      {
        int breadResult = (NumOfBread * 5);
        return breadResult;
      }
      else if (NumOfBread % 3 != 0)
      {
        int breadResult = ((((NumOfBread - (NumOfBread % 3)) / 3) * 10) + ((NumOfBread % 3) * 5));
        return breadResult;
      }
      // else if (numOfBread % 3 == 2)
      // {
      //   int breadResult = ((((numOfBread - (numOfBread % 3)) / 3) * 10) + ((numOfBread % 3) * 5));
      //   return breadResult;
      // }
      else
      {
        int breadResult = ((NumOfBread / 3) * 10);
        return breadResult;
      }
    }

  }
}