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
      if (PastryOrder>2)
      {
        Total = PastryOrder*2-(PastryOrder/3);
        return Total;
      }
      else
      {
        Total = PastryOrder * 2;
        return Total;
      }
    }
  }
}
