using System;

class Logic
{
  int a;
  int b;

  public Logic(int num1,int num2)
  {
    a=num1;
    b=num2;
  }
  public int Add()
  {
    return a+b;
  }

  public void Subtract()
  {
    int result=a-b;
    Console.WriteLine($" result of subtraction is {result}");
  }

  public int Multiply()
  {
    return a*b;
  }

  public void Divide()
  {
    double result=Convert.ToDouble(a)/Convert.ToDouble(b);
    Console.WriteLine($"result of division is {result}");
  }


}