using System;
using System.Globalization;
using System.Text;
class Program
{
  public static void Main()
  {
    StringBuilder sbb=new StringBuilder("hello world");

    for(int i = 0; i < sbb.Length; i++)
    {
      Console.Write(sbb[i]);
    }
    StringBuilder sb=new StringBuilder();
    sb.AppendLine("Worldd");
    sb.Append("Hello");
    sb.AppendLine("Worldddd");
    sb.AppendLine("helllo cpp");
    Console.Write(sb);

    StringBuilder sbamount=new StringBuilder("oyour total amount is ");
    sbamount.AppendFormat("{0:c}",25);

    CultureInfo india=new CultureInfo("en-IN");
    sbamount.AppendFormat(india,"{0:C}",12345678);

    Console.WriteLine(sbamount);
  }
}