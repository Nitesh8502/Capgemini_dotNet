using System;
public abstract class Furniture
{
  protected int num;
  protected string color;
  protected int width;
  protected int height;

  public Furniture()
  {
    num = 0;
    color = string.Empty;
    width = 0;
    height = 0;
  }

  public abstract void Accept();
  public abstract void Display();

  public void Mymethod()
  {
    Console.WriteLine("Mymethod");
  }

}