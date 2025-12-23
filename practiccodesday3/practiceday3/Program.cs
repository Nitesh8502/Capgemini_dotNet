using System;

class Program
{
  public static void Main()
  {
    Logic obj=new Logic(40,30);
    int sum=obj.Add();
    Console.WriteLine("sum of the quesiton is {0}",sum);

    obj.Subtract();

    int multiply=obj.Multiply();
    Console.WriteLine("multiplication of the quesiton is {0}",multiply);

    obj.Divide();
  }
}