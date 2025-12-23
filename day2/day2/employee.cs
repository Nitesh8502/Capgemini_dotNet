using System;
class Employee
{
  private int empId = 0;
  private string name = String.Empty;
  private string department = string.Empty;
  private float salary = 0.0f;
  private bool status = true;

  public int EmpId
  {
    get
    {
      return empId;
    }
    set
    {
      empId=value;
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

  public string Department
  {
    get
    {
      return department;
    }
    set
    {
      department=value;
    }
  }

  public float Salary
  {
    get
    {
      return salary;
    }
    set
    {
      salary=value;
    }
  }

  public bool Status
  {
    get
    {
      return status;
    }
    set
    {
      status=value;
    }
  }
  public void AcceptDetails()
  {
    Console.WriteLine("Eneter employee details");
    Console.WriteLine("enter  employee id");
    EmpId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter employee name");
    Name = Console.ReadLine();
    Console.WriteLine("Ente remployee department");
    Department = Console.ReadLine();
    Console.WriteLine("Enter employee salary");
    Salary = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("EnterEmployee staatus on true or false");
    Status = Convert.ToBoolean(Console.ReadLine());
  }

  public void DisplayDetails()
  {
    Console.WriteLine("Employeee Detailsss");
    Console.WriteLine($"Employee Department is {Department}");
    Console.WriteLine($"Employee name is {Name}");
    Console.WriteLine($"Employee id is {EmpId}");
    Console.WriteLine($"Employee salaty is {Salary}");
    Console.WriteLine($"Employee status is {Status}");

  }

}