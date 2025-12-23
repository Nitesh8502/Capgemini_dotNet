using System;


public class StringConverter
{
 
  public string ConvertString(string input)
  {
    return input.ToUpper();
  }

  
  public string ConvertString(string input, bool tolower)
  {
    return input.ToLower();
  }


  public string ConvertString(string input, int ccharrkdadm)
  {
    if (string.IsNullOrEmpty(input)) return input;

    string[] words = input.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i].Length == 0) continue;
      string first = words[i].Substring(0, 1).ToUpper();
      string rest = words[i].Length > 1 ? words[i].Substring(1).ToLower() : "";
      words[i] = first + rest;
    }

    return string.Join(" ", words);
  }
}

class Program
{
  static void Main()
  {
    string input = Console.ReadLine();
    int choice = int.Parse(Console.ReadLine());

    StringConverter converter = new StringConverter();

    if (choice == 1)
    {
      Console.WriteLine(converter.ConvertString(input));
    }
    else if (choice == 2)
    {
      Console.WriteLine(converter.ConvertString(input, true));
    }
    else if (choice == 3)
    {
      Console.WriteLine(converter.ConvertString(input, 3));
    }
    else
    {
      Console.WriteLine("Invalid choice.");
    }
  }
}
