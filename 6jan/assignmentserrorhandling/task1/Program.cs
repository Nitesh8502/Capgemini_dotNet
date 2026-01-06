using System;

class Program
{
  static void Main()
  {
    try
    {
      
      double temperature = Convert.ToDouble(Console.ReadLine());

      
      string Type = Console.ReadLine();

      if (Type == "F")
      {
        double cel = (temperature - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Celsius: {cel}");
      }
      else if (Type == "C")
      {
        double faaa = (temperature * 9 / 5) + 32;
        Console.WriteLine($"Temperature in Fahrenheit: {faaa}");
      }
      else
      {
        Console.WriteLine("Invalid conversion Please enter 'F' or 'C'.");
      }
    }
    catch (SystemException ex)
    {
      Console.WriteLine("Invalid input provided.");
      Console.WriteLine($"Exception Message: {ex.Message}");
    }
  }
}
