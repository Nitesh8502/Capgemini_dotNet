using System;
using System.Collections;

public class Program
{
  private static ArrayList numbers = new ArrayList();

  private static void Main()
  {
    while (true)
    {
      string command = Console.ReadLine();

      if (command == "add")
      {
        AddNumber();
      }
      else if (command == "remove")
      {
        RemoveNumber();
      }
      else if (command == "display")
      {
        DisplayNumbers();
      }
      else if (command == "exit")
      {
        break;
      }
      else
      {
        Console.WriteLine("Invalid command.");
      }
    }
  }

  private static void AddNumber()
  {
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
      numbers.Add(number);
      Console.WriteLine(number + " added to the number list.");
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
    }
  }

  private static void RemoveNumber()
  {
    string input = Console.ReadLine();
    int number;

    if (int.TryParse(input, out number))
    {
      if (numbers.Contains(number))
      {
        numbers.Remove(number);
        Console.WriteLine(number + " removed from the number list.");
      }
      else
      {
        Console.WriteLine(number + " not found in the number list.");
      }
    }
    else
    {
      Console.WriteLine("Invalid input. Please enter a valid number.");
    }
  }

  private static void DisplayNumbers()
  {
    Console.WriteLine("Current numbers in the list:");
    foreach (int num in numbers)
    {
      Console.WriteLine(num);
    }
  }
}
