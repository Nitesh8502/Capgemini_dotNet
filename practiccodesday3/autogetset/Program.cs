using System;

class CalculatorData
{
  public int Number1 { get; set; }
  public int Number2 { get; set; }

  public int Result { get; private set; }

  public void ComputeTotal()
  {
    Result = Number1 + Number2;
  }
  public int Sum => Number1 + Number2;
}

class Program
{
  static void SwapByValue(int a, int b)
  {
    Console.WriteLine($"  (SwapByValue) before: a={a}, b={b}");
    int t = a; a = b; b = t;
    Console.WriteLine($"  (SwapByValue) after:  a={a}, b={b}");
  }

  static void SwapByRef(ref int a, ref int b)
  {
    Console.WriteLine($"  (SwapByRef) before: a={a}, b={b}");
    int t = a; a = b; b = t;
    Console.WriteLine($"  (SwapByRef) after:  a={a}, b={b}");
  }

  static void AdditionOut(int n1, int n2, out int total, out int m1, out int m2)
  {
    m1 = n1;
    m2 = n2;
    total = n1 + n2;
  }

  static void Main()
  {
    Console.WriteLine("=== Properties / Encapsulation ===");
    CalculatorData data = new CalculatorData { Number1 = 12, Number2 = 8 };
    Console.WriteLine($"Number1={data.Number1}, Number2={data.Number2}, Sum={data.Sum}");
    data.ComputeTotal();
    Console.WriteLine($"Result (after ComputeTotal) = {data.Result}");

    Console.WriteLine("\n=== Call-by-value (SwapByValue) ===");
    int s1 = 50000, s2 = 30000;
    Console.WriteLine($"Before: s1={s1}, s2={s2}");
    SwapByValue(s1, s2);
    Console.WriteLine($"After:  s1={s1}, s2={s2}  (unchanged)");

    Console.WriteLine("\n=== ref swap (SwapByRef) ===");
    Console.WriteLine($"Before: s1={s1}, s2={s2}");
    SwapByRef(ref s1, ref s2);
    Console.WriteLine($"After:  s1={s1}, s2={s2}  (swapped)");

    Console.WriteLine("\n=== out parameters (AdditionOut) ===");
    AdditionOut(40, 50, out int total, out int m1, out int m2);
    Console.WriteLine($"Total={total}, Subject1={m1}, Subject2={m2}");
  }
}