using System;
using System.IO;

class Program
{
  public static void Main()
  {
    FileStream fileStream = new FileStream(@"C:\filehandling\dota.txt", FileMode.Open, FileAccess.Write);
    StreamWriter streamWriter = new StreamWriter(fileStream);
    Console.WriteLine("enter some text ");
    string str = Console.ReadLine();
    streamWriter.WriteLine(str ?? string.Empty);
    streamWriter.Close();
    fileStream.Close();
  }
}