using System;


  public class Logic
  {
    public void Swap(ref int a, ref int b)
    {
      int temp = a;
      a = b;
      b = temp;
    }
  }


  class Calculator
{
  public int Num1 { get; set; }//autoimplement property
  public int Num2 { get; set; }
  public int Result { get; set; }

  public Calculator()//Default Constructor
  {
    Num1=0;
    Num2=0;
    Result=0;
  }

  public Calculator(int Num1,int Num2)
  {
    this.Num1=Num2;
    this.Num2=Num2;
  }

  public int Add(int num1,int num2)
  {
    Num1=num1;
    Num2=num2;
    Result=num1+num2;
    return Result;
  }

  public void Multiply(int num1, num2)
  {
     Num1=num1;
    Num2=num2;

    Result=Num1*Num2;
    Console.WriteLine($" product of two {Num1} and {Num2} is {Result}");

  }
  public void Divide()
  {
    int num1=30;
    int num2=2;
    Result=num1/num2;
    Console.WriteLine($"Dividsio of the nuber is{Result}");

  }

  public void swap(int num1,int num2)
  {
    int temp=0;
    temp=num1;
    num1=num2;
    num2=temp;
  }

  public void swap(ref int num3,ref int num4)
  {
    int temp=0;
    temp=num3;
    num3=num4;
    num4=temp;
    Console.WriteLine($"after swapping num3 and num4 {num3}  {num4}");
  }

  public void Addition(int n1,int n2,out int result,out int n3, out int n4)
  {
    n3=n1;
    n4=n2;
    result=n1+n2;
  }

}

