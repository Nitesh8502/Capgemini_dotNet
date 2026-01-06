using System;
class Program
{
  public static void Main()
  {
    Employee employee=new Employee();
    employee[0]="String 1";
    employee[1]="String 2";
    employee[2]="String 3";
    employee[3]="String 4";
    employee[4]="String 5";

    for(int i = 0; i < 5; i++)
    {
      Console.WriteLine(employee[i]);
    }
  }
}