using System;
using Microsoft.VisualBasic;

class Logic
{
  private string year;
  public string Year
  {
    get{return year;}
    set{year=value;}
  }
  public void input()
  {
    Console.WriteLine("Enter the year: ");
    Year=Console.ReadLine();
    
    if (Year.Length != 4)
    {
      Console.WriteLine("Enter valid year");
    }
  }
  public void checkyear()
  {
    int saal=Convert.ToInt32(Year);
    if ((saal % 4 == 0 && saal % 100 != 0) || saal % 400 == 0)
    {
        Console.WriteLine($"{Year} is Leapyear");
    }
    else
    {
      Console.WriteLine($"{Year} is not Leapyear");
    }
  }
}