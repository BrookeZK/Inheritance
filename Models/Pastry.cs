namespace Bakery.Models
{
  public class Pastry : Item
  {
    public Pastry()
    {
      Cost = 2;
    }
    public override void CalculateOrder()
    {
      TotalCost = Cost * Quantity;
      if (Quantity % 2 == 0) 
      {
        TotalCost -= 2;
      }
    }
  }
}