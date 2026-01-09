using System;
using System.Globalization;
using System.IO;
class FileInfoDemo
{
  public static void Main()
  {
    // string path=@"mytestfile.txt";
    // FileInfo f1=new FileInfo(path);
    // File.Create(path);
    // {
    //   Console.WriteLine("file has been created");
    // }

    // FileInfo f1=new FileInfo("mytestfilecreated2.txt");
    // StreamWriter str=f1.CreateText();
    // str.WriteLine("ahkgrllhkgrj;lkdsa");
    // Console.WriteLine("file has been created with text");
    // str.Close();

    // FileInfo f1=new FileInfo("mytestfilecreated2.txt");
    // f1.Delete();
    // Console.WriteLine("file has been deleted");


    // string path=@"Mytestfile.txt";
    // string path2=@"newfile.txt";
    // FileInfo f1=new FileInfo(path);
    // FileInfo f2=new FileInfo(path2);
    // f1.CopyTo(path2);
    // Console.WriteLine("{0} was copied to {1}",path,path2);

    // string path=@"Mytestfile.txt";
    // string path2=@"newfile2.txt";
    // FileInfo f1=new FileInfo(path);
    // FileInfo f2=new FileInfo(path2);
    // f1.MoveTo(path2);
    // Console.WriteLine("{0} was moved to {1}",path,path2);


    // FileInfo f1=new FileInfo("newfile2.txt");
    // StreamWriter sw=f1.AppendText();
    // sw.WriteLine("jingle my balsss");
    // Console.WriteLine("my balls have been added");
    // sw.Close();

  // FileInfo f1=new FileInfo("newfile2.txt");
  // StreamReader sr=f1.OpenText();
  // string s="";
  //   while ((s = sr.ReadLine()) != null)
  //   {
  //     Console.WriteLine(s);
  //   }
    

  FileInfo fi = new FileInfo("newfile.txt");
 Console.WriteLine("File name is {0}: ",fi.Name);
 Console.WriteLine("File creation time is {0}: ",fi.CreationTime.ToLongTimeString());
 Console.WriteLine("File exists is: {0}", fi.Exists);
 Console.WriteLine("File last accessmtime is: {0}", fi.LastAccessTime.ToLongDateString());
 Console.WriteLine("File length is {0}", fi.Length.ToString() + " Bytes");
 Console.WriteLine("File extension is: {0}:",fi.Extension);
  }
}