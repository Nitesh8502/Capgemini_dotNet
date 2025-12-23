using System;

public class Person
{
  private string name;
  private int age;
  private string address;

  public string Name
  {
    get {
       return name; 
       }
    set 
    {
       name = value; 
    }
  }

  public int Age
  {
    get { 
      return age; 
      }
    set { 
      age = value; 
      }
  }

  public string Address
  {
    get { 
      return address;
       }
    set { 
      address = value; 
      }
  }
}

class Program
{
  static void Main()
  {
    Person person = new Person();

    Console.WriteLine("Enter the name");
    person.Name = Console.ReadLine();
    Console.WriteLine("Enter the age");
    person.Age = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the address");
    person.Address = Console.ReadLine();

    Console.WriteLine("Person Information:");
    Console.WriteLine("Name: " + person.Name);
    Console.WriteLine("Age: " + person.Age);
    Console.WriteLine("Address: " + person.Address);
  }
}
