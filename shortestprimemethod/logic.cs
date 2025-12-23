using System;
class Calculator
{

  public int Num1 { get; set; }//autoimplement property
  public int Num2 { get; set; }
  public int Result { get; set; }

  public Calculator()//default constructor
  {
    Num1 = 0;
    Num2 = 0;
    Result = 0;
  }
  public Calculator(int num1, int num2)//parameterised constructor
  {
    this.Num1 = num1;
    this.Num2 = num2;
  }
  public int Add(int num1, int num2)
  {
    //Num1 = num1;
    // Num2 = num2;

    Result = num1 + num2;
    return Result;
  }
  public void Swap(int num1,int num2){
    int n1=num1;
    int n2=num2;
    int temp=0;

    Console.WriteLine($"Before swaping {num1} and {num2}");
    temp1=n1;
    n1=n2;
    n2=temp;
  }
}