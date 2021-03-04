namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastry { get; }

    public Pastry(int numOfPastry)
    {
      NumOfPastry = numOfPastry;
    }

    public int PastryPriceTotal(int numOfPastry)
    {
      if (numOfPastry % 3 == 0)
      {
        int pastryResult = ((numOfPastry / 3) * 5);
        return pastryResult;
      }
      else if (numOfPastry < 3)
      {
        int pastryResult = (numOfPastry * 2);
        return pastryResult;
      }
      else
      {
        int pastryResult = (((numOfPastry - (numOfPastry % 3)) / 3) * 5) + ((numOfPastry % 3) * 2);
        return pastryResult;
      }
    }
  }
}