using System;
using System.Collections.Generic;

public class Program
{
  public static HashSet<string> stringSet = new HashSet<string>();

  public static void Main()
  {
    while (true)
    {
      DisplayMenu();
      Console.Write("Enter your choice: ");
      int choice;

      if (!int.TryParse(Console.ReadLine(), out choice))
      {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        continue;
      }

      switch (choice)
      {
        case 1:
          AddString();
          break;
        case 2:
          DisplayStrings();
          break;
        case 3:
          UpdateString();
          break;
        case 4:
          DeleteString();
          break;
        case 5:
          Console.WriteLine("Exiting...");
          return;
        default:
          Console.WriteLine("Please enter a valid choice between 1 and 5.");
          break;
      }
    }
  }

  public static void DisplayMenu()
  {
    Console.WriteLine("\nChoose an operation:");
    Console.WriteLine("1: Create (Add a new string)");
    Console.WriteLine("2: Read (Display all strings)");
    Console.WriteLine("3: Update (Update an existing string)");
    Console.WriteLine("4: Delete (Remove a string)");
    Console.WriteLine("5: Exit");
  }

  public static void AddString()
  {
    Console.Write("Enter the string to add: ");
    string input = Console.ReadLine();

    if (stringSet.Add(input))
    {
      Console.WriteLine($"'{input}' has been added.");
    }
    else
    {
      Console.WriteLine($"'{input}' already exists in the set.");
    }
  }

  public static void DisplayStrings()
  {
    Console.WriteLine("Current items in the set:");

    if (stringSet.Count == 0)
    {
      return;
    }

    foreach (string item in stringSet)
    {
      Console.WriteLine(item);
    }
  }

  public static void UpdateString()
  {
    Console.Write("Enter the string to update: ");
    string oldValue = Console.ReadLine();

    if (!stringSet.Contains(oldValue))
    {
      Console.WriteLine($"'{oldValue}' does not exist in the set.");
      return;
    }

    Console.Write("Enter the new string: ");
    string newValue = Console.ReadLine();

    if (stringSet.Contains(newValue))
    {
      Console.WriteLine($"Update failed. '{newValue}' already exists in the set.");
      return;
    }

    stringSet.Remove(oldValue);
    stringSet.Add(newValue);
    Console.WriteLine($"'{oldValue}' has been updated to '{newValue}'.");
  }

  public static void DeleteString()
  {
    Console.Write("Enter the string to delete: ");
    string input = Console.ReadLine();

    if (stringSet.Remove(input))
    {
      Console.WriteLine($"'{input}' has been removed.");
    }
    else
    {
      Console.WriteLine($"'{input}' does not exist in the set.");
    }
  }
}
