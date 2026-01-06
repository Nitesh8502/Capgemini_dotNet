using System;

public class Program
{
  public static void Main()
  {
    try
    {
      Console.WriteLine("enter elemtts of firtst aaray ");
      string input1 = Console.ReadLine();
      int[] numbers1 = Array.ConvertAll(input1.Split(' '), int.Parse);

      Console.WriteLine("enter elemtts of second aaray ");
      string input2 = Console.ReadLine();
      int[] numbers2 = Array.ConvertAll(input2.Split(' '), int.Parse);


      if (numbers1.Length != numbers2.Length)
      {
        Console.WriteLine("Error: Arrays must have the same length for addition.");
        return;
      }


      int[] sumArray = new int[numbers1.Length];
      for (int i = 0; i < numbers1.Length; i++)
      {
        sumArray[i] = numbers1[i] + numbers2[i];
      }


      int index = Convert.ToInt32(Console.ReadLine());


      Console.WriteLine(
        $"Element at index {index} in the sum array: {sumArray[index]}"
      );
    }
    catch (FormatException ex)
    {
      Console.WriteLine("Error: Invalid input format. Please enter integers only.");
      Console.WriteLine($"Exception Message: {ex.Message}");
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine("Error: Index out of range for the sum array.");
      Console.WriteLine($"Exception Message: {ex.Message}");
    }
  }
}
