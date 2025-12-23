using System;
class StaticInstanceDemo
{
  public int var=0;//instance variable 
  public static int var1=5;//static variable

  public void Count()//instance method
  {
    var1++;
  }
  public static int Display()//static method
  {
    return var1;
  }
}