using System;

public class Employee
{
  protected double hourlyRate;
  protected double hoursWorked;

  public Employee(double hourlyRate, double hoursWorked)
  {
    this.hourlyRate = hourlyRate;
    this.hoursWorked = hoursWorked;
  }

  public virtual double CalculateSalary()
  {
    return hourlyRate * hoursWorked;
  }
}

public class FullTimeEmployee : Employee
{
  public FullTimeEmployee(double hourlyRate, double hoursWorked)
    : base(hourlyRate, hoursWorked) { }

  public override double CalculateSalary()
  {
    return hourlyRate * hoursWorked;
  }
}

public class PartTimeEmployee : Employee
{
  public PartTimeEmployee(double hourlyRate, double hoursWorked)
    : base(hourlyRate, hoursWorked) { }

  public override double CalculateSalary()
  {
    return (hourlyRate * 0.8) * hoursWorked;
  }
}

public class Intern : Employee
{
  public Intern(double hourlyRate, double hoursWorked)
    : base(hourlyRate, hoursWorked) { }

  public override double CalculateSalary()
  {
    return (hourlyRate * 0.6) * hoursWorked;
  }
}

public class Program
{
  public static void Main()
  {
    int numberOfEmployees;

    if (!int.TryParse(Console.ReadLine(), out numberOfEmployees) || numberOfEmployees <= 0)
    {
      Console.WriteLine("Please enter a valid positive integer.");
      return;
    }

    Employee[] employees = new Employee[numberOfEmployees];
    string[] employeeTypes = new string[numberOfEmployees];

    for (int i = 0; i < numberOfEmployees; i++)
    {
      while (true)
      {
        string type = Console.ReadLine().ToLower();

        if (type != "fulltimeemployee" && type != "parttimeemployee" && type != "intern")
        {
          Console.WriteLine("Unknown employee type. Please enter FullTimeEmployee, PartTimeEmployee, or Intern.");
          continue;
        }

        double hourlyRate;
        if (!double.TryParse(Console.ReadLine(), out hourlyRate))
        {
          Console.WriteLine("Invalid input for hourly rate. Please enter a numeric value.");
          continue;
        }

        double hoursWorked;
        if (!double.TryParse(Console.ReadLine(), out hoursWorked))
        {
          Console.WriteLine("Invalid input for hours worked. Please enter a numeric value.");
          continue;
        }

        if (type == "fulltimeemployee")
        {
          employees[i] = new FullTimeEmployee(hourlyRate, hoursWorked);
          employeeTypes[i] = "FullTimeEmployee";
        }
        else if (type == "parttimeemployee")
        {
          employees[i] = new PartTimeEmployee(hourlyRate, hoursWorked);
          employeeTypes[i] = "PartTimeEmployee";
        }
        else
        {
          employees[i] = new Intern(hourlyRate, hoursWorked);
          employeeTypes[i] = "Intern";
        }

        break;
      }
    }

    Console.WriteLine("Salaries of the employees:");
    for (int i = 0; i < employees.Length; i++)
    {
      Console.WriteLine(
        $"Salary of Employee {i + 1} ({employeeTypes[i]}): {employees[i].CalculateSalary()}"
      );
    }
  }
}
