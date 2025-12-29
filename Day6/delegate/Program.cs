using System;
namespace CalculatorApp
{
  public delegate int CalculatorDelegate(int num1, int num2);
  class Program
  {
    public static void Main()
    {
      Calculator calculator = new Calculator();
      CalculatorDelegate calcutAdd = new CalculatorDelegate(calculator.Add);
      CalculatorDelegate calcutSubtract = new CalculatorDelegate(calculator.Subtract);
      CalculatorDelegate calcutMultiply = new CalculatorDelegate(calculator.Multiply);
      CalculatorDelegate calcutDivide = new CalculatorDelegate(calculator.Divide);

      CalculatorDelegate calcutMulticast;

      int sum = calcutAdd(30, 20);
      Console.WriteLine($"Sum of the Two Number is : {sum}");

      int subtract = calcutSubtract(30, 20);
      Console.WriteLine($"Subtraction of the Two Number is : {subtract}");

      int mult = calcutMultiply(30, 20);
      Console.WriteLine($"Multiplication of the Two Number is : {mult}");

      int div = calcutDivide(30, 20);
      Console.WriteLine($"Division of the Two Number is : {div}");

      calcutMulticast = calcutAdd;
      calcutMulticast = calcutSubtract;
      calcutMulticast = calcutMultiply;
      calcutMulticast = calcutDivide;

      Console.WriteLine("called multicast delegate {0}", calcutMulticast(30, 3));
    }
  }
}