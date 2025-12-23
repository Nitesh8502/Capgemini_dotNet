using System;
public class Student
{
  public string Name { get; set; }
  public int Age { get; set; }
  public string Grade { get; set; }

  public Student(){
    Name="Nitesh Dotasara";
    Age=21;
    Grade="O";

  }
  public Student(string name, int age, string grade)
  {
    Name=name;
    Age=age;
    Grade=grade;
  }
  public void Display()
  {
    Console.WriteLine($"Name: {Name}");
    Console.WriteLine($"Age: {Age}");
    Console.WriteLine($"Grade: {Grade}");
  }

}

class Program
{
  static void Main()
  {
    Student defobj=new Student();
    Console.WriteLine("Default student");
    defobj.Display();

    string name = Console.ReadLine();
    int age = int.Parse(Console.ReadLine());
    string grade = Console.ReadLine();


    Student obj=new Student(name,age,grade);
    Console.WriteLine("not default student");
    obj.Display();
    
    
  }
}