using System;
class Logic
{
  private int regno = 0;
  private string name = String.Empty;
  private int marks=0;
  private string division=string.Empty;

  public int Regno
  {
    get
    {
      return regno;
    }
    set
    {
      regno=value;
    }
  }

  public string Name
  {
    get
    {
      return name;
    }
    set
    {
      name=value;
    }
  }

  public int Marks
  {
    get
    {
      return marks;
    }
    set
    {
      marks=value;
    }
  }
  public string Division
  {
    get
    {
      return division;
    }
    set
    {
      division=value;
    }
  }

  public void AcceptDetails()
  {
  Console.WriteLine("Eneter student details");
  Console.WriteLine("enter  student id");
  Regno = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Enter student name");
  Name = Console.ReadLine();
  Console.WriteLine("Enter Total marks");
  Marks=Convert.ToInt32(Console.ReadLine());
  
  }
  public void ShowDetails()
  {
    
    int avg=marks/6;
    if (avg>= 60)
      division ="First Division";
    else if (avg>=45)
      division ="Second Division";
    else if (avg>=33)
      division="Third Division";
    else
      division ="Fail";
    Console.WriteLine(Name);

    Console.WriteLine(division);

  }

}