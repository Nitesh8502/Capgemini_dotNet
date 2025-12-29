using System;
public class Employee
{
  protected int Eid, Eage;
  protected string Ename, Eaddress;
  protected float Salary;
  //why virtual method -> because we want to override it in derived class
  public virtual void GetEmployeeDetails()
  {
    Console.WriteLine("Enter Employee Details:");
    Console.WriteLine("Enter Employee Id: ");
    Eid = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Name: ");
    Ename = Console.ReadLine();
    Console.WriteLine("Enter Employee Address: ");
    Eaddress = Console.ReadLine();
    Console.WriteLine("Enter Employee Age: ");
    Eage = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Employee Salary: ");
    Salary = float.Parse(Console.ReadLine() ?? "0");
  }
  public virtual void DisplayEmployeeDetails()
  {
    Console.WriteLine("Employee Details:");
    Console.WriteLine($"Employee Id: {Eid}");
    Console.WriteLine($"Employee Name: {Ename}");
    Console.WriteLine($"Employee Address: {Eaddress}");
    Console.WriteLine($"Employee Age: {Eage}");
    Console.WriteLine($"Employee Salary: {Salary}");
  }
  public virtual void CalculateSalary()
  {
    Console.WriteLine($"Employee Salary : {Salary}");
  }
}