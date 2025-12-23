using System;
class Program
{
  public static void swap(ref int a,ref int b)
  {
    Console.WriteLine($"befor swapping inside swap {a} and {b}");
    int temp=a;
    a=b;
    b=temp;
    Console.WriteLine($"After calling swap inside swap {a} and {b}");
  }
  public static void Main()
  {
    int a=200;
    int b=500;
    Console.WriteLine($" Before calling swap {a} and {b}");
    swap(ref a, ref b);
    Console.WriteLine($"after using swap by ref in main function {a} and {b}");
  }
}