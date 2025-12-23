using System;

 class Program
  {
    static void Main()
    {
      //  Default billing
      Logic defaultCalc = new Logic();
      Console.WriteLine("Default Billing Total: " + defaultCalc.Add());
      Console.WriteLine("Default Billing Amount: " + defaultCalc.Multiply());

      // Customer-specific billing
      Logic customerCalc = new Logic(5, 100);
      Console.WriteLine("Customer Billing Total: " + customerCalc.Add());
      Console.WriteLine("Customer Billing Amount: " + customerCalc.Multiply());
    }
  }