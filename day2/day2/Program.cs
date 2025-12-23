using System;
using System.ComponentModel.DataAnnotations;
class program
{
  public static void Main(string[] args)
  {
    Employee employee=new Employee();

    // employee.AcceptDetails();
    // employee.DisplayDetails();

    Employee  employee1=new Employee();
    employee1.EmpId=1002;
    employee1.Name="Nitesh";
    employee1.Salary=10000f;
    employee1.Status=true;
    employee1.Department="cse";

    employee1.DisplayDetails();
    Console.ReadKey();
  }
}