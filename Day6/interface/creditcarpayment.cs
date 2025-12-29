using System;
class CreditCardPayment:IPayment
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
internal interface IPayment
{
  void Pay(double amount);
  void Refund(double amount);
}

