using System;
using System.Collections;
using System.Data.Common;
class Program
{
  public static void Main()
  {
    ArrayList list=new ArrayList();
    Employee employee1=new Employee(){Id=10,Name="Rajesh"};
    Employee employee2=new Employee(){Id=20,Name="sdfjesh"};
    Employee employee3=new Employee(){Id=10,Name="mahesh"};
    list.Add(30);
    list.Add(10);
    list.Add(20);
    list.Add(40);
    list.Add(60);
    
    list.Add(employee1);
    list.Add(employee2);
    list.Add(employee3);

    Console.WriteLine($"count of arrray list is {list.Count}");

    foreach(var item in list)
    {
      Console.WriteLine(item);
    }

    ArrayList list1=new ArrayList();
    list1.Add(80);
    list1.Add(810);
    list1.Add(30);

    list.AddRange(list1);

    Console.WriteLine("\n\n\n list after adding range");
    foreach(var item in list)
      Console.WriteLine(item);

    Console.WriteLine($"count of array list is {list.Count}");

    //list.Clear();
    //Console.WriteLine($"after clearing list count of arrray list is {list.Count}");

    Console.WriteLine("\n\n\nafter clearing range");

    foreach(var item in list)
      Console.WriteLine(item);

    if (list.Contains(90))
    {
      Console.WriteLine($"object 50 is at index no {list.IndexOf(50)}");
    }
    else
    {
      Console.WriteLine("object not found");
    }

    list.RemoveAt(5);
    Console.WriteLine("\n\n\n after removing value at index 5 range in list");

    foreach(var item in list)
      Console.WriteLine(item);

    list.Remove(false);
    Console.WriteLine("\n\n\n List after removing value false from the list");
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    list.RemoveRange(5,3);

    Console.WriteLine("\n\n\n after removing range from the list");

    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    Console.Write("\n\n\n list before sorting the list");
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }
    list.Sort();
    Console.WriteLine("\n\n\n list after sorting");
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }

    list.Reverse();

    Console.WriteLine("\n\n\n list after reversing the list");
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }
    list.Insert(3,69);

     Console.WriteLine("\n\n\n list after inserting at index 3 the list");
    foreach (var item in list)
    {
      Console.WriteLine(item);
    }
  }
}