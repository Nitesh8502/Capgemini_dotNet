using System;

class Program
{
  public static void Main()
  {
    //question one
    Console.WriteLine("enter the length of array: ");
    int n=Convert.ToInt32(Console.ReadLine());

    int[] arr=new int[n];
    int[] brr=new int[n];
    int sum=0;
    for(int i = 0; i < n; i++)
    {
     arr[i]= Convert.ToInt32(Console.ReadLine());
     sum+=arr[i];
    }

    // for(int i = 0; i < n; i++)
    // {
    //   Console.WriteLine($"elemtn {i} is {arr[i]}");
    // }

    //question 2
    // for(int i = n - 1; i >= 0; i--)
    // {   
    //   Console.WriteLine($"elemtn {i} is {arr[i]}");
    // }
    
    //q3
    //Console.WriteLine($"sum is {sum}");

    //q4
    
    // for(int i = 0; i < n; i++)
    // {
    //   brr[i]=arr[i];
    // }
    // for(int i = 0; i < n; i++)
    // {
    //   Console.WriteLine($"elemtn {i} is {brr[i]}");
    // }

    //q5
    //   for (int i = 0; i < n; i++)
    // {
    //   int duplicateCount = 0;

    //   for (int j = i + 1; j < n; j++)
    //   {
    //     if (arr[i] == arr[j])
    //     {
    //       duplicateCount++;
    //     }
    //   }

    //   if (duplicateCount > 0)
    //   {
    //     count++;
    //   }
    // }
    // Console.WriteLine("Total number of duplicate elements found in the array is : {0}", count);

    //q6
    
    // for (int i = 0; i < n; i++)
    // {
    //   int count = 0;

    //   for (int j = 0; j < n; j++)
    //   {
    //     if (arr[i] == arr[j])
    //     {
    //       count++;
    //     }
    //   }

    //   if (count == 1)
    //   {
    //     Console.WriteLine(arr[i]);
    //   }
    // }

   //q7 
  //  Array.Sort(arr);
   
  //   for(int i = 0; i < n; i++)
  //   {
  //     Console.WriteLine($"elemtn {i} is {arr[i]}");
  //   }

  //q8
  // int[] frr=new int[n];
  // for (int i = 0; i < n; i++)
  //   {
  //     int count = 0;

  //     for (int j = 0; j < n; j++)
  //     {
  //       if (arr[i] == arr[j])
  //       {
  //         count++;
  //       }
  //       frr[i]=count;
  //     }
      
  //   }
  //   for(int i = 0; i < n; i++)
  //   {
  //     Console.WriteLine($"elemtn {frr[i]} is {arr[i]}");
  //   }

  //q9
  // int max=-99;
  //    for(int i = 0; i < n; i++)
  //   {
  //     if (arr[i] > max)
  //     {
  //       max=arr[i];
  //     }
    
  //   }
  //     Console.WriteLine($"max element  is {max}");

  //q10
  int[] even=new int[n];
  int[] odd=new int[n];
  int ecount=0,ocount=0;
  for(int i = 0; i < n; i++)
    {

      if (arr[i] % 2 == 0)
      {
        even[ecount]=arr[i];
        ecount++;
      }
      else
      {
        odd[ocount]=arr[i];
        ocount++;
      }
    }
    for(int i = 0; i < ecount; i++)
    {
      Console.WriteLine($"element {even[i]}");

    }
  }
}