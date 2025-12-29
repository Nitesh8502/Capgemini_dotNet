using System;
using System.Linq.Expressions;

class Program
{
  public static void Main()
  {
    IPayment payment;
    payment=new CreditCardPayment();
    payment.Refund(1000.0);
    payment.Pay(1000.0);
  }
}