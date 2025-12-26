using System;

class Program
{
  static void Main(string[] args)
  {
    UnitConverter converter = new UnitConverter();

    Console.WriteLine("Enter conversion type (Length / Weight / Temperature):");
    string type = Console.ReadLine();

    Console.WriteLine("Enter value to convert:");
    double value = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter from unit:");
    string fromUnit = Console.ReadLine();

    Console.WriteLine("Enter to unit (press Enter for default):");
    string toUnit = Console.ReadLine();

    double result;

    if (string.IsNullOrEmpty(toUnit))
    {
      result = converter.Convert(value, fromUnit);
      Console.WriteLine("Converted Value: " + result);
    }
    else
    {
      result = converter.Convert(value, fromUnit, toUnit);
      Console.WriteLine("Converted Value: " + result + " " + toUnit);
    }
  }
}
