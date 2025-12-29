using System;
namespace PartialDemo
{
  class Program
  {
    public static void Main()
    {
      partialEmployee part=new partialEmployee();
      part.FirstName="sdsgag";
      part.DiaplayEmployeeDetails();
      part.DisplayFullName();
      part.PartialMethod();
    }
  }
}