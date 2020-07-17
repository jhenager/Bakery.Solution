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
      Total = BreadOrder * 5;
      return Total;
    }
  }
}
