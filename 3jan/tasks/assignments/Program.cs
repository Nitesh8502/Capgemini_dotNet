using System;

class Program
{
  static void Main()
  {
    
    Console.Write("enter number of products: ");
    int n = int.Parse(Console.ReadLine());

    
    int[] prices = new int[n];

   
    for (int i = 0; i < prices.Length; i++)
    {
      while (true)
      {
        Console.Write($"enter price for product {i + 1}: ");
        int value = int.Parse(Console.ReadLine());

        if (value > 0)
        {
          prices[i] = value;
          break;
        }
        else
        {
          Console.WriteLine("Price must be positive. Try again.");
        }
      }
    }


    int sum = 0;
    for (int i = 0; i < prices.Length; i++)
    {
      sum += prices[i];
    }
    int average = sum / prices.Length;

    Array.Sort(prices);

    for (int i = 0; i < prices.Length; i++)
    {
      if (prices[i] < average)
      {
        prices[i] = 0;
      }
    }

    int oldLength = prices.Length;
    Array.Resize(ref prices, prices.Length + 5);


    for (int i = oldLength; i < prices.Length; i++)
    {
      prices[i] = average;
    }

   
    Console.WriteLine("\nFinal Array Output:");
    for (int i = 0; i < prices.Length; i++)
    {
      Console.WriteLine($"Index {i} : {prices[i]}");
    }
  }
}
