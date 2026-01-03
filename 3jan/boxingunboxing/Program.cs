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
        
        List<string> empName=new List<string>();
        empName.Add("Rajesh");
        Employee employee1=new Employee()
        {
            Id=10,
            Name="Ramesh"
        };
        Employee employee2=new Employee()
        {
            Id=20,
            Name="lamesh"
        };

        List<Employee> employees=new List<Employee>();
        employees.Add(employee1);
        employees.Add(employee2);
        
        foreach(Employee e in employees)
        {
            Console.WriteLine(e);
        }

        Dictionary<int,string> directory=new Dictionary<int,string>();
        directory.Add(100,"nitesh");
        directory.Add(200,"jiteshsh");

        foreach(KeyValuePair<int,string> key in directory)
        {
            Console.WriteLine($"key is {key.Key} value is {key.Value}");
        }

        SortedList<string,string> pairs=new SortedList<string,string>();
        pairs.Add("100","Rajesh");
        pairs.Add("200","kamajesh");
        pairs.Add("100","ramlalesh");
        Console.WriteLine("\n\n generic sorted list");
        foreach(KeyValuePair<int,string> key in pairs)
        {
            Console.WriteLine($"key is {key.Key} value is {key.Value}");
        }

        Stack<char> stack=new Stack<char>();
        stack.Push('A');
        stack.Push('B');
        stack.Push('C');
        stack.Push('D');
        stack.Push('E');

        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }
        stack.Pop();
        Console.WriteLine("after removindg peak");
        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }

        Queue<char> queue=new Queue<char>();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        queue.Enqueue('D');
        queue.Enqueue('E');

        foreach(var item in queue)
        {
            Console.WriteLine($"{item} ");
        }

        queue.Dequeue();
        Console.WriteLine("after dequeing from queue ");
        foreach(var item in queue)
        {
            Console.WriteLine($"{item} ");
        }


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