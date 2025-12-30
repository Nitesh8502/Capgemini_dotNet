using System;
using System.Data.Common;
using System.Runtime.InteropServices.Marshalling;
class Program
{
    public static void Main(String[] args)
    {

      Employee employee1=new Employee(){Id=30,Name="Rajesh"};
      Employee employee2=new Employee(){Id=50,Name="Rajesh"};
      Employee employee3=new Employee(){Id=70,Name="Rajesh"};
      Employee employee4=new Employee(){Id=40,Name="Rajesh"};
      Employee employee5=new Employee(){Id=20,Name="Rajesh"};
      Employee[] employeeList=new Employee[5];

      employeeList[0]=employee1;
      employeeList[1]=employee2;
      employeeList[2]=employee3;
      employeeList[3]=employee4;
      employeeList[4]=employee5;

      Console.WriteLine("Before sorting");
      foreach(Employee e in employeeList)
    {
      Console.WriteLine(e);
    }

    Array.Sort(employeeList);
      Console.WriteLine("after sorting");
      foreach(Employee e in employeeList)
    {
      Console.WriteLine(e);
    }


        int[] arr=new int[6]{50,20,30,10,40,60};

        System.Console.WriteLine($"Array index at the value 50: {Array.IndexOf(arr, 50)}");
        System.Console.WriteLine($"Array Value at  index 3:  {arr.GetValue(3)}");

        System.Console.WriteLine($"Array is Fixedsize {arr.IsFixedSize}");
        System.Console.WriteLine($"Array is Readonly {arr.IsReadOnly}");
        
        System.Console.WriteLine($"Array Rank {arr.Rank}");
        System.Console.WriteLine($"Array is Fixedsize {arr.IsFixedSize}");
        System.Console.WriteLine("\n\n");


        System.Console.WriteLine("Before Sorting: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        System.Console.WriteLine("After Sorting: ");
        Array.Sort(arr);
        
        Console.WriteLine("befor reversing");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


        Console.WriteLine(" after Reverse: ");
        Array.Reverse(arr);
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }


        Program program=new Program();
        Employee employee =new Employee
        {
          Id=90,
          Name="Dinesh Kumar"

        };
        program.PassObject(employee);
        employee employee6=program.ReturnObject();
        Console.WriteLine(employee6);

        program.PassArrayObject(employeeList);
        
    }
    public void PassObject(Employee employee)
  {
    Console.WriteLine(employee);
  }
  public Employee ReturnObject()
  {
    Employee employee=new Employee
    {
      Id=120,
      Name="sursh kumaarr"
    };
    return employee;
  }

  public void PassArrayObject(Employee[] employee)
  {
    foreach(Employee e in employee)
    {
      Console.WriteLine(e);
    }
  }
}