namespace Bakery.Models
{
  public class Bread : Item
  {
    public Bread()
    {
      Cost = 5;
    }
    public override void CalculateOrder()
    {
      TotalCost = Cost * Quantity;
      if (Quantity % 5 == 0) 
      {
        TotalCost -= 5;
      }
    }
  }
}