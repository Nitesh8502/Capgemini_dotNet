using System;
using System.Data.Common;
using System.Linq.Expressions;
class Program
{
  private static void Main()
  {
    Mycollectoin mycollectoin=new Mycollectoin();
    foreach(int i in mycollectoin)
    {
      Console.WriteLine("collection item: "+ i);
    }
  }
}