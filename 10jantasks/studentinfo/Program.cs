using System;
using System.Collections.Generic;

public class Student
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Grade { get; set; }
}

public class StudentManager
{
  public Dictionary<int, Student> Students { get; set; }

  public StudentManager()
  {
    Students = new Dictionary<int, Student>();
  }

  public void AddStudent(Student student)
  {

    Students[student.Id] = student;
  }

  public void DisplayStudents()
  {
    Console.WriteLine("Student Information:");
    foreach (var student in Students.Values)
    {
      Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Grade: {student.Grade}");
    }
  }
}

class Program
{
  static void Main()
  {
    StudentManager manager = new StudentManager();

    Console.WriteLine("Enter number of students:");
    string countLine = Console.ReadLine();
    if (!int.TryParse(countLine, out int numberOfStudents) || numberOfStudents <= 0)
    {
      Console.WriteLine("Invalid number of students. Exiting.");
      return;
    }

    for (int i = 0; i < numberOfStudents; i++)
    {
      Console.WriteLine($"\nStudent #{i + 1}:");

      Console.Write("Id: ");
      string idLine = Console.ReadLine();
      if (!int.TryParse(idLine, out int id))
      {
        Console.WriteLine("Invalid id. Skipping this student.");
        continue;
      }

      Console.Write("Name: ");
      string name = (Console.ReadLine() ?? string.Empty).Trim();
      if (string.IsNullOrWhiteSpace(name))
      {
        Console.WriteLine("Empty name. Skipping this student.");
        continue;
      }

      Console.Write("Grade: ");
      string grade = (Console.ReadLine() ?? string.Empty).Trim();

      var student = new Student
      {
        Id = id,
        Name = name,
        Grade = grade
      };

      if (manager.Students.ContainsKey(id))
      {
        Console.WriteLine($"Warning: Student with id {id} already exists. Overwriting.");
      }

      manager.AddStudent(student);
    }

    Console.WriteLine();
    manager.DisplayStudents();
  }
}
