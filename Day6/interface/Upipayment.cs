using System;
class UPIPayment : IPayment
{
   public void Pay(double amount)
  {
    Console.WriteLine($"paid {amount} using creit card");
  }
  public void Refund(double amount)
  {
    Console.WriteLine($" refund is {amount} to credit card");
  }
}