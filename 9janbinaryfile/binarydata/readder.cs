using System;
using System.IO;

class BinaryreadExample
{
  static void Main2()
  {
    string filepath="employee.dat";
    using (FileStream fs=new FileStream(filepath,FileMode.Open))
    using(BinaryReader reader=new BinaryReader(fs))
    {
      int id=reader.ReadInt32();
      string name=reader.ReadString();
      double salary=reader.ReadDouble();
      bool isActive=reader.ReadBoolean();

      Console.WriteLine($" id is {id}");
      Console.WriteLine($" name is {name}");
      Console.WriteLine($" salary is {salary}");
      Console.WriteLine($" active is {isActive}");
    }
  }
}