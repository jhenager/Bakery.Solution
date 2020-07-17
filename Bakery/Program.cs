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
      string breadInput = Console.ReadLine();

      if (numberChecker(breadInput) == false)
      {
        Console.WriteLine("Please enter a number with no spaces or extra characters");
        Main();
      }
      
      Bread bread1 = new Bread(int.Parse(breadInput));
      Console.WriteLine("How many pastries would you like?");
      string pastryInput = Console.ReadLine();

      if (numberChecker(pastryInput)== false)
      {
        Console.WriteLine("Please enter a number with no spaces or extra characters");
        Main();
      }

      Pastry pastry1 = new Pastry(int.Parse(pastryInput));
      Order order1 = new Order(bread1.BreadTotal(), pastry1.PastryTotal());
      Console.WriteLine("Thank you. For " + breadInput + " loaves of bread and " + pastryInput + " pastries, your total is $" + order1.OrderTotal());
    }

    public static bool numberChecker(string input)
    { 
      foreach(char number in input)
      {
        if (char.IsNumber(number) != true)
        {
          return false;
        }
      }
        return true;
    }
  }
}