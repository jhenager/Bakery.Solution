namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryOrder {get; set;}
    public int Total {get; set;}

    public Pastry(int pastryOrder)
    {
      PastryOrder = pastryOrder;
      Total = Total;
    }

    public int PastryTotal()
    {
      Total = PastryOrder * 2;
      return Total;
    }
  }
}
