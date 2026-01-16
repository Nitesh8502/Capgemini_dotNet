using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
  static void Main(string[] args)
  {
    string input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input  ))
      return;

    var numbers = ParseIntegers(input);
    var odds = GetOddNumbers(numbers);

    if (odds.Count > 0)
      Console.WriteLine(string.Join(" ", odds));
  }

  private static List<int> ParseIntegers(string input)
  {
    var result = new List<int>();
    if (string.IsNullOrWhiteSpace(input)) return result;

    var tokens = input.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    foreach (var token in tokens)
    {
      if (int.TryParse(token, out int value))
        result.Add(value);
    }
    return result;
  }

  private static List<int> GetOddNumbers(List<int> numbers)
  {
    return numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList();
  }
}