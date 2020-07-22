using System;
using Bakery.Models;
namespace Bakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How much ya want!");
      string amount = Console.ReadLine();
      Bread myBread = new Bread();
      myBread.AddItems(int.Parse(amount));
      myBread.CalculateOrder();
      Console.WriteLine(myBread.TotalCost);
      Console.WriteLine("More? Enter 'y' for yes");
      string answer = Console.ReadLine();
      if (answer == "y" || answer == "Y") {
        Main();
      }
    }
  }
}