using System;
class MyException: Exception
{
  public MyException(string str)
  {
    Console.WriteLine("User defined exception");
  }
}