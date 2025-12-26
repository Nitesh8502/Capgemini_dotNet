using System;

public class Cloth
{
  public int ID { get; set; }

  public Cloth(int id)
  {
    ID = id;
  }
}

public class Men : Cloth
{
  public int Size { get; set; }
  public string return_cloth = "YES";

  public Men(int id, int size) : base(id)
  {
    Size = size;
  }

  public void DisplayInfo()
  {
    Console.WriteLine("MEN ID: " + ID);
    Console.WriteLine("Size: " + Size);
    Console.WriteLine("Return Option within a Week: " + return_cloth);
  }
}

public class Women : Cloth
{
  public int Size { get; set; }
  public string MaterialType { get; set; }
  public string return_cloth = "YES";

  public Women(int id, int size, string materialType) : base(id)
  {
    Size = size;
    MaterialType = materialType;
  }

  public void DisplayInfo()
  {
    Console.WriteLine("Women Cloth ID: " + ID);
    Console.WriteLine("Size: " + Size);
    Console.WriteLine("Material Type: " + MaterialType);
    Console.WriteLine("Return Option within a Week: " + return_cloth);
  }
}

public class Kids : Cloth
{
  public int Size { get; set; }
  public string return_cloth = "NO";

  public Kids(int id, int size) : base(id)
  {
    Size = size;
  }

  public void DisplayInfo()
  {
    Console.WriteLine("KID Cloth ID: " + ID);
    Console.WriteLine("Size: " + Size);
    Console.WriteLine("Return Option: " + return_cloth);
  }
}

public class Program
{
  public static void Main(string[] args)
  {
    int menId = int.Parse(Console.ReadLine());
    int menSize = int.Parse(Console.ReadLine());

    int womenId = int.Parse(Console.ReadLine());
    int womenSize = int.Parse(Console.ReadLine());
    string materialType = Console.ReadLine();

    int kidId = int.Parse(Console.ReadLine());
    int kidSize = int.Parse(Console.ReadLine());

    Men men = new Men(menId, menSize);
    Women women = new Women(womenId, womenSize, materialType);
    Kids kid = new Kids(kidId, kidSize);

    men.DisplayInfo();
    women.DisplayInfo();
    kid.DisplayInfo();
  }
}
