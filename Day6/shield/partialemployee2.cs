using System;
namespace PartialDemo
{
  public partial class PartialEmployee
  {
    public void DisplayFullName()
    {
      Console.WriteLine("Full name is : {0} {1}", FirstName, LastName);
    }
    public void DiaplayEmployeeDetails()
    {
      Console.WriteLine("Employee Details:");
      Console.WriteLine($"Full Name: {FirstName} {LastName}");
      Console.WriteLine($"Gender   : {Gender}");
      Console.WriteLine($"Salary   : {Salary}");
    }
  }
}