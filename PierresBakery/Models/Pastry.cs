namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastry { get; }

    public Pastry(int numOfPastry)
    {
      NumOfPastry = numOfPastry;
    }

    public int PastryPriceTotal()
    {
      if (NumOfPastry <= 0)
      {
        int pastryResult = (NumOfPastry * 0);
        return pastryResult;
      }
      else if (NumOfPastry % 3 == 0)
      {
        int pastryResult = ((NumOfPastry / 3) * 5);
        return pastryResult;
      }
      else if (NumOfPastry < 3)
      {
        int pastryResult = (NumOfPastry * 2);
        return pastryResult;
      }
      else
      {
        int pastryResult = (((NumOfPastry - (NumOfPastry % 3)) / 3) * 5) + ((NumOfPastry % 3) * 2);
        return pastryResult;
      }
    }
  }
}