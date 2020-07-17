namespace Bakery.Models
{
  public class Bread
  {
    public int BreadOrder {get; set;}
    public int Total {get; set;}
  

    public Bread(int breadOrder)
    {
      BreadOrder = breadOrder;
      Total = Total;
    }

    public int BreadTotal()
    {
      if (BreadOrder>2)
      {
        Total = BreadOrder*5-((BreadOrder/3)*5);
        return Total;
      }
      else
      {
        Total = BreadOrder * 5;
        return Total;
      }
    }
  }
}
