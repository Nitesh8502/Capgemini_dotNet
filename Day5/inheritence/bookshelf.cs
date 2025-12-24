using System;
using System.Drawing;
using System.Globalization;
class Bookshelf : Furniture
{
  public override void Accept()
  {
    Console.WriteLine("Enter number of shelves:");
    num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter color:");
    color = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("Enter width:");
    width = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter height:");
    height = Convert.ToInt32(Console.ReadLine());
  }
  public override void Display()
  {
    Console.WriteLine("num of shelves is : {0}", num);
    Console.WriteLine("color is : {0}", color);
    Console.WriteLine("height is  : {0}", height);
    Console.WriteLine("width is : {0}", width);
  }
}
