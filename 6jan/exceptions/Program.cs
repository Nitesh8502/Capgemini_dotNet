using System;
class Program
{
  public static void Main()
  {

    try
    {
      throw new OutOfMemoryException("hjgsjmns");
    }
    catch(Exception e)
    {
      Console.WriteLine("exception caught here"+e.ToString());
    }
    Console.Writeline("last statement");
    // int num1=0;
    // int num2=0;

    // int result=0;

    // int[] arr=new int[6]{10,20,30,46,50,60};

    

    // try{
      
    // Console.WriteLine("enter the first number");
    // num1=Convert.ToInt32(Console.ReadLine());

    // Console.WriteLine("enter the second number");
    // num2=Convert.ToInt32(Console.ReadLine());
    //   result=num1/num2;

     
    //     for(int i = 0; i < 9; i++)
    //       {
    //         Console.WriteLine(arr[i]);
    //       }
      
      
    // }
    // catch(IndexOutOfRangeException ex)
    // {
    //   Console.WriteLine($"Index is out of range {ex.Message}");
    // }

    // catch(DivideByZeroException ex)
    // {
    //   Console.WriteLine($"cannot divide number by zero {ex.Message.ToString()}");
      
    // }
    // catch(FormatException ex)
    // {
    //   Console.WriteLine($"enter number only  {ex.Message}" );
    // }
    // catch(Exception ex)
    // {
    //   Console.WriteLine(ex.Message.ToString());
    // }
    // finally{

    //   Console.WriteLine($"outpur of the division of two numbers {num1} and {num2} is {result}");
    // }
    // Console.WriteLine($"outpur of the division of two numbers {num1} and {num2} is {result}");
  }
}