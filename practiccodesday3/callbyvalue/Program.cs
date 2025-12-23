using System;

class Program
{
  public static void Swap(int a,int b){
    Console.WriteLine($"before swapping inside swap {a} and {b}");
    int temp=a;
    a=b;
    b=temp;
    Console.WriteLine($"after swapping inside swap {a} and {b}");
  }

  public static void Main(){
    int a=5335;
    int b=4234;

    Console.WriteLine($"before swapping calling swap {a} and {b}");
    Swap(a,b);
    Console.WriteLine($"after swapping calling swap {a} and {b}");
  }
}