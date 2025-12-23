using System;
class Logic
{
  private int num1;
  private int num2;
  public Logic()
  {
    this.num1=5;
    this.num2=6;  
  }

  public Logic(int a,int b)
  {
    this.num1=a;
    this.num2=b;
  }

  public int Add()
  {
    return num1+num2;
  }
  public int Multiply()
  {
    return num1*num2;
  }
  
}