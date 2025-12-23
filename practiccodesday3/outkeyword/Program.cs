using System;

class Program
{
  public static void Addition(int n1,int n2,out int result,out int n3,out int n4)
  {
    n3=n1;
    n4=n2;
    result=n1+n2;
  }
  static void Main()
  {
    int mark1=34;
    int mark2=23;
    Addition(mark1,mark2,out int total,out int m1,out int m2);

    Console.WriteLine($"Total={total}");
    Console.WriteLine($"marks are {m1} and {m2}");
  }
}