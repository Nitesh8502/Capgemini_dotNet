using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Car
{
  public string Storename { get; set; }
  public string Model { get; set; }   
  public int Year { get; set; }

  public Car(string storename, string model,int year)
  {
    Storename=storename;
    Model=model;
    Year=year;
  }

  public  void Display()
  {
    Console.WriteLine("Storename of the car is {0}",Storename);
    Console.WriteLine("Model of the car is {0}",Model);
    Console.WriteLine("Year of the car is {0}",Year);
  }
  public void Countage()
  {
    int Age=2026-Year;
    Console.WriteLine("Age of the car is {0}",Age);
  }

}

class Program
{
  public static void Main()
  {
    

  Console.WriteLine("Enter the Storename: ");
  string storename=Console.ReadLine();
  Console.WriteLine("Enter the Modelname: ");
  string model=Console.ReadLine();
  Console.WriteLine("Enter the Year bought: ");
  int year=Convert.ToInt32(Console.ReadLine());

  Car obj=new Car(storename,model,year);
  obj.Display();
  obj.Countage();


  }

}