namespace Bakery.Models
{
  public class Order
  {
    public int AllBread {get; set;}
    public int AllPastry {get; set;}

    public Order(int allBread, int allPastry)
    {
      AllBread = allBread;
      AllPastry = AllPastry;
    }
  }
}
