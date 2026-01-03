using System.Collections;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        // Hashtable hashtable = new Hashtable();
        // hashtable.Add(200,"Suresh");
        // hashtable.Add(300,"John Cena");
        // hashtable.Add(400,"Roman Reigns");
        // hashtable.Add(500,"Brett Lee");
        // hashtable.Add(600,"Sachin");
        // ICollection key = hashtable.Keys;
        // foreach(var k in key)
        // {
        //     Console.WriteLine(k);
        // }
        // ICollection value = hashtable.Values;
        // Console.Write("All the values are : ");
        // foreach(var v in value)
        // {
        //     Console.Write(v+", ");
        // }
        // Console.WriteLine();
        // foreach(var key1 in key)
        // {
        //     Console.WriteLine($"Key is {key1} and value is {hashtable[key1]}");
        // }
        // Console.WriteLine("Enter the key you want to search in the hashtable : ");
        // int key2 = Convert.ToInt32(Console.ReadLine());
        // if (hashtable.ContainsKey(key2))
        // {
        //     Console.WriteLine($"Found {key2} with the value {hashtable[key2]}");
        // }
        // else
        // {
        //     Console.WriteLine("Key Not Found");
        // }


        //-------Sorted List-----------------
        SortedList list = new SortedList();
        list.Add(200,"Suresh");
        list.Add(300,"John Cena");
        list.Add(400,"Roman Reigns");
        list.Add(500,"Brett Lee");
        list.Add(600,"Sachin");
        ICollection key3 = list.Keys;
        
        foreach(var k in key3)
        {
            Console.WriteLine($"Key is {k} and value is {list[k]}");
        }

        //accessing using index
        Console.WriteLine($"Index of 500 is : {list.IndexOfKey(500)}");

        Console.WriteLine("After Clearing the List: ");
        list.Clear();
        int count=list.Count;
        if (count == 0)
        {
            Console.WriteLine("List Elements are Cleared");
        }


        // //stackk=================
        // Stack stack=new Stack();
        // stack.Push('A');
        // stack.Push('B');
        // stack.Push('C');
        // stack.Push('D');
        // stack.Push('E');

        // foreach(var v in stack)
        // {
        //     Console.WriteLine(v);
        // }

        // Console.WriteLine($"element at top is {stack.Peek()}");

        // stack.Pop();
        // Console.WriteLine($"element at top is {stack.Peek()}");

        // Console.WriteLine("Enter element to find " );
        // char ch=Convert.ToChar(Console.ReadLine());
        // if (stack.Contains(ch))
        // {
        //     Console.WriteLine($"element {ch} found");
        // }
        // else
        // {
        //      Console.WriteLine($"element {ch} not found");
        // }


        ///queueee=====
        
        Queue queue=new Queue();
        queue.Enqueue('A');
        queue.Enqueue('B');
        queue.Enqueue('C');
        queue.Enqueue('D');
        queue.Enqueue('E');
        
        foreach(var v in queue)
        {
            Console.Write($"{v}");
        }
        
    }
}