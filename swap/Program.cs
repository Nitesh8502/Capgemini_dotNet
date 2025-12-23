using System;


  class Program
  {
    static void Main()
    {
      int x = 10;
      int y = 20;

      Logic obj = new Logic();

      Console.WriteLine("Before swapping:");
      Console.WriteLine("x = " + x + ", y = " + y);

      obj.Swap(ref x, ref y); 

      Console.WriteLine("After swapping:");
      Console.WriteLine("x = " + x + ", y = " + y);
    }
  }

