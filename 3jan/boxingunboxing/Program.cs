using System.Collections;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        

        //----------------------Generic------------------------------
        // int x = 10;
        // object obj = x;   // BOXING
        
        // int y = (int)obj; // UNBOXING

        // ArrayList list = new ArrayList();
        // list.Add(10);      
        // list.Add(false);
        // list.Add(65.5f);
        // int x = (int)list[0]; // unboxing

        //-------------Compile Time Vs RunTime--------(var vs Dynamic)----------
        //var x = 10;
        //x = "Hello";   // compile-time error

        //dynamic y = 10;
        //y = "Hello";   // ✔ allowed
        //Console.WriteLine(y);


        AddClass addClass = new AddClass();
        Console.WriteLine($"Sum of the Integer is : {addClass.AddInt(30,20)}");
        Console.WriteLine($"Sum of the Float is : {addClass.AddFloat(30.10f,20.03f)}");
        Console.WriteLine($"Sum of the String is : {addClass.AddString("Abc","Def")}");

        //generic class
        AddGenericClass<int> addInteger1 = new AddGenericClass<int>();
        Console.WriteLine($"Sum of the Integer using Generic Class is : {addInteger1.AddAllType(30,20)}");

        AddGenericClass<float> addFloat = new AddGenericClass<float>();
        Console.WriteLine($"Sum of the float using Generic Class is : {addFloat.AddAllType(20.03f,27.20f)}");

        AddGenericClass<string> addString = new AddGenericClass<string>();
        Console.WriteLine($"Sum of the String using Generic Class is : {addString.AddAllType("Abc","Def")}");
        //AddGenericClass<int> addInteger2 = new AddGenericClass<int>(20,30);

    }
}