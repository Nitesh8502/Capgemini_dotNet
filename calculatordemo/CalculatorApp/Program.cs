using System;
using System.Globalization;

class Program
{
  int num1;
  int num2;
  int result;
  public static void Main(string[] args)
  {
    // int i=10;
    // while (i > 0)
    // {
    //   Console.WriteLine($"the number is : {i}");
    //   i--;
    // }

    // int i=0;
    // do
    // {
    //   Console.WriteLine($"number is {i}");
    //   i++;
    // }
    // while(i<=10);

    // int i=10;
    // do
    // {
    //   Console.WriteLine($"Reverse number is {i}");
    //   i--;
    // }
    // while(i>=0);

    // for(int i = 0; i <= 10; i++)
    // {
    //   Console.WriteLine($"number is {i}");
    // }

    // for(int i = 10; i >= 0; i--)
    // {
    //   Console.WriteLine($"number is {i}");
    // }

    int[] arr={10,20,30,40,50,60,70,80,90,100};

    // foreach(int i in arr)
    // {
    //   Console.WriteLine(i);
    // }
    
    // for(int i = 0; i < arr.Length; i++)
    // {
    //   Console.WriteLine($"array index at {i} is {arr[i]}");
    // }

    int i=0;
    while (i < arr.Length)
    {
      Console.WriteLine($"array at index{i} is {arr[i]}");
      i++;
    }

    //Program program = new Program();
    // int choice = 0;
    // System.Console.WriteLine("Select option from following list");
    // Console.WriteLine("1 for Addition");
    // Console.WriteLine("2 for substraction");
    // Console.WriteLine("3 for Multiplication");
    // Console.WriteLine("4 for Division");
    // Console.WriteLine("5 for Reminder");
    // Console.WriteLine("6 for exit");
    // Console.WriteLine("select option from following list");
    // choice = Convert.ToInt32(Console.ReadLine());

    // switch (choice)
    // {
    //   case 1:
    //     program.Add();
    //     break;
    //   case 2:
    //     program.Subtract();
    //     break;
    //   case 3:
    //     program.Multiply();
    //     break;
    //   case 4:
    //     program.Divide();
    //     break;
    //   case 5:
    //     program.Reminder();
    //     break;
    //   case 6:return;
    //   default:System.Console.WriteLine("Invalid choice");
    //     break;
    // }
  }

  public void Add()
  {
    Console.WriteLine("Enter the number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 + num2;
    Console.WriteLine("The addition of two numbers is: ", result);
  }
  public void Subtract()
  {
    Console.WriteLine("Enter the number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 - num2;
    Console.WriteLine($"The subtraction of two numbers{num1} and {num2} is: {result}");

  }
  public void Multiply()
  {
    Console.WriteLine("Enter the number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 * num2;
    Console.WriteLine($"The multiplication of two numbers{num1} and {num2} is: {result}");
  }
  public void Divide()
  {
    Console.WriteLine("Enter the number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter the number: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    result = num1 / num2;
    Console.WriteLine($"The division of two numbers{num1} and {num2} is: {result}");

  }

  public void Reminder()
  {
    Console.WriteLine("Enter the first number");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    num2 = Convert.ToInt32(Console.ReadLine());

    result = num1 % num2;

    Console.WriteLine($"The division of two numbers{num1} and {num2} is: {result}");

  }
}