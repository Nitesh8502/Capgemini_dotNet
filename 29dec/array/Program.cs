using System;
class Program
{
  public static void Main(string[] args)
  {
    // int[] arr;

    // Console.Write("Enter number of elements: ");
    // int n;
    // while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
    // {
    //   Console.Write("Invalid input. Enter a positive integer: ");
    // }

    // arr = new int[n];

    // for (int i = 0; i < n; i++)
    // {
    //   Console.Write($"Enter element {i}: ");
    //   while (!int.TryParse(Console.ReadLine(), out arr[i]))
    //   {
    //     Console.Write("Invalid integer. Enter again: ");
    //   }
    // }

    // Console.WriteLine("Array elements:");
    // for (int i = 0; i < arr.Length; i++)
    // {
    //   Console.WriteLine($"arr[{i}] = {arr[i]}");
    // }


    // Console.Write("Enter number of characters: ");
    // int m;
    // while (!int.TryParse(Console.ReadLine(), out m) || m < 1)
    // {
    //   Console.Write("Invalid input. Enter a positive integer: ");
    // }

    // char[] carr = new char[m];
    // for (int i = 0; i < m; i++)
    // {
    //   Console.Write($"Enter character {i}: ");
    //   string s = Console.ReadLine();
    //   while (string.IsNullOrEmpty(s) || s.Length != 1)
    //   {
    //     Console.Write("Invalid input. Enter a single character: ");
    //     s = Console.ReadLine();
    //   }
    //   carr[i] = s[0];
    // }

    // Console.WriteLine("Character array elements:");
    // for (int i = 0; i < carr.Length; i++)
    // {
    //   Console.WriteLine($"carr[{i}] = {carr[i]}");
    // }

    // int total = Sum(arr);
    // Console.WriteLine($"Sum of integer array elements: {total}");

    //    int [,] arr=new int[3,3];
    //     arr[0,0]=10;
    //     arr[0,1]=20;
    //     arr[0,2]=30;
    //     arr[1,0]=40;
    //     arr[1,1]=50;
    //     arr[1,2]=60;
    //     arr[2,0]=70;
    //     arr[2,1]=80;
    //     arr[2,2]=90;
    //     Console.WriteLine("Element is 3*3 matrix is: ");
    //     for(int i=0;i<arr.GetLength(0);i++)
    //     {
    //         for(int j=0;j<arr.GetLength(1);j++)
    //         {
    //             Console.Write(arr[i,j]+" ");
    //         }
    //         Console.WriteLine();

    // }
    int k=0;
        int l=0;
        int [,] arr=new int[k,l];
        // arr[0,0]=10;
        // arr[0,1]=20;
        // arr[0,2]=30;
        // arr[1,0]=40;
        // arr[1,1]=50;
        // arr[1,2]=60;
        // arr[2,0]=70;
        // arr[2,1]=80;
        // arr[2,2]=90;
        
        Console.Write("Enter number of rows: ");
        k=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number of columns: ");
        l=Convert.ToInt32(Console.ReadLine());
        arr=new int[k,l];
        Console.WriteLine("Enter the elements of the matrix: ");
        for(int i=0;i<k;i++)
        {
            for(int j=0;j<l;j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                arr[i,j]=Convert.ToInt32(Console.ReadLine());
            }
        }

        //Console.WriteLine("Element is 3*3 matrix is: ");
        for(int i=0;i<arr.GetLength(0);i++)
        {
            for(int j=0;j<arr.GetLength(1);j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();

    }

  }

  public static int Sum(int[] a)
  {
    int s = 0;
    foreach (int v in a)
      s += v;
    return s;
  }
}