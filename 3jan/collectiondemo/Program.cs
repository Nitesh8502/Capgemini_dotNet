using System.Collections;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;

internal class Program
{
    private static void Main(string[] args)
    {
        
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