using System;
using System.Collections;
class Program
{
  public static void Main()
  {
    ArrayList nameslist=new ArrayList();

    while (true)
    {
      string input=Console.ReadLine();
      if (input == null)
      {
        continue;
      }
      if (input.Equals("stop",StringComparison.OrdinalIgnoreCase)){
        break;
      }
      if (!isvalid(input))
      {
        continue;
      }
      if (isnameinlist(nameslist,input))
      {
        Console.WriteLine("name is already in the list");
      }
      else
      {
        nameslist.Add(input);
        Console.WriteLine("name is added in the list");
      }

      display(nameslist);

    }
  }
    private static bool isnameinlist(ArrayList nameslist,string name)
  {
    foreach(string oldname in nameslist)
    {
      if (oldname.Equals(name, StringComparison.OrdinalIgnoreCase))
      {
        return true;
      }
    }
    return false;
  }
  private static void display(ArrayList nameslist)
  {
    Console.WriteLine("unique students aded are: ");
    foreach(string name in nameslist)
    {
      Console.WriteLine(name);
    }
  }
  private static bool isvalid(string name)
  {
    return !string.IsNullOrWhiteSpace(name);
  }
}