using System;
class Program//subscriber class
{
  public static void Main()
  {
    // AddTwoNumber a=new AddTwoNumber();
    // a.ev_OddNumber+=new AddTwoNumber.dg_OddNumber(EventMessage);
    // a.Add();

    // Func<int,int,int> Addition=AddNumber;
    // int result=Addition(10,20);
    // Console.WriteLine($"Addition = {result}");

    // Action<int,int> Addition=AddNumber;
    // int result=Addition(10,20);
    // Console.WriteLine($"Addition = {result}");

    Predicate<string> Checkifapple=Isapple;
    bool result=Isapple("nokia");
    if (result)
    {
      Console.WriteLine("it is an i phone");
    }
  }
  //delegates call this method when raised.
  // static void EventMessage(){
  //     Console.WriteLine("event executed .this is odd number");
  //   }

  // private static int AddNumber(int para1,int para2)
  // {
  //   return para1+para2;
  // }
  // private static void AddNumber(int para1,int para2)
  // {
  //   return para1+para2;
  // }
private static bool Isapple(string s)
{
  return s?.IndexOf("iphone", StringComparison.OrdinalIgnoreCase) >= 0
         || s?.IndexOf("i phone", StringComparison.OrdinalIgnoreCase) >= 0;
}

}