namespace Design_Principles.OCP.Violation
{
  public class Customer
  {
    public decimal Discount(decimal amount, int type)
    {
      decimal result = 0;    
      if (type == 1)
      {
        result = amount;
      }
      else if (type == 2)
      {
        result = amount - (amount * 5)/100;
      }
      else if (type == 3)
      {
        result = amount - (amount * 10)/100;
      }
      else if (type == 4)
      {
        result = amount - (amount * 20)/100;
      }
      return result;
    }
  }
}