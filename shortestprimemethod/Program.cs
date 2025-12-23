using System;

class Program
{
  public static void Main(string[] args)
  {
    Calculator calculator=new Calculator();

    int num1=10;
    int num2=20;
    int sum=calculator.Add(num1,num2);
    Console.WriteLine($" sum of the numver {num1} and {num2} is {sum}");
  }
}