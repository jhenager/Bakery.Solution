using System;
using Bakery.Models;

namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Henager Bakery!");
      Console.WriteLine("We offer Bread and Pastries.");
      Console.WriteLine("Bread is $5 a loaf. Our special is buy 2 get 1 free.");
      Console.WriteLine("Pastries are $2 each. Our special is buy 2 get 1 half off.");
      Console.WriteLine("How many loaves of bread would you like?");
      int breadInput = int.Parse(Console.ReadLine());
      Bread bread1 = new Bread(breadInput);
      Console.WriteLine("How many pastries would you like?");
      int pastryInput = int.Parse(Console.ReadLine());
      Pastry pastry1 = new Pastry(pastryInput);
      Order order1 = new Order(bread1.BreadTotal(), pastry1.PastryTotal());
      Console.WriteLine("Thank you. For " + breadInput + " loaves of bread and " + pastryInput + " pastries, your total is " + order1.OrderTotal());
    }
  }
}