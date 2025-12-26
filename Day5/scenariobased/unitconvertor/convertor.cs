using System;

public class UnitConverter
{
  // Convert with explicit target unit
  public double Convert(double value, string fromUnit, string toUnit)
  {
    fromUnit = fromUnit.ToLower();
    toUnit = toUnit.ToLower();

    // Length
    if (fromUnit == "meters" && toUnit == "kilometers")
      return value * 0.001;

    if (fromUnit == "kilometers" && toUnit == "meters")
      return value * 1000;

    if (fromUnit == "miles" && toUnit == "feet")
      return value * 5280;

    if (fromUnit == "feet" && toUnit == "miles")
      return value / 5280;

    // Weight
    if (fromUnit == "grams" && toUnit == "kilograms")
      return value * 0.001;

    if (fromUnit == "kilograms" && toUnit == "grams")
      return value * 1000;

    if (fromUnit == "pounds" && toUnit == "ounces")
      return value * 16;

    if (fromUnit == "ounces" && toUnit == "pounds")
      return value / 16;

    // Temperature
    if (fromUnit == "celsius" && toUnit == "fahrenheit")
      return (value * 9 / 5) + 32;

    if (fromUnit == "fahrenheit" && toUnit == "celsius")
      return (value - 32) * 5 / 9;

    if (fromUnit == "celsius" && toUnit == "kelvin")
      return value + 273.15;

    if (fromUnit == "kelvin" && toUnit == "celsius")
      return value - 273.15;

    throw new Exception("Unsupported conversion");
  }

  // Convert to default unit
  public double Convert(double value, string fromUnit)
  {
    string defaultUnit = GetDefaultUnit(fromUnit);
    return Convert(value, fromUnit, defaultUnit);
  }

  // Default unit based on category
  private string GetDefaultUnit(string fromUnit)
  {
    fromUnit = fromUnit.ToLower();

    switch (fromUnit)
    {
      // Length
      case "kilometers":
      case "miles":
      case "feet":
        return "meters";

      // Weight
      case "grams":
      case "pounds":
      case "ounces":
        return "kilograms";

      // Temperature
      case "fahrenheit":
      case "kelvin":
        return "celsius";

      default:
        return fromUnit;
    }
  }
}
