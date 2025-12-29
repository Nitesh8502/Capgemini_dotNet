using System;

public  class  Animal{
  public virtual void MakeSound()
  {
    Console.WriteLine("some sound");
  }

}
public class Dog : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Bark");
  }
}
public class Cat : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Meow");
  }
}

public class Program
{
  public static void Main()
  {
    int n;
    while (true)
    {
      if(!int.TryParse(Console.ReadLine(),out n)){
        Console.WriteLine("please enter the valid input");
        return;
      }
      if (n < 0)
      {
        Console.WriteLine("please enter positive number");
        return;
      }
      break;
    }

    
    Animal[] animals = new Animal[n];


    for (int i = 0; i < n; i++)
    {
      while (true)
      {
        string input = Console.ReadLine().ToLower();

        if (input == "animal")
        {
          animals[i] = new Animal();
          break;
        }
        else if (input == "dog")
        {
          animals[i] = new Dog();
          break;
        }
        else if (input == "cat")
        {
          animals[i] = new Cat();
          break;
        }
        else
        {
          Console.WriteLine("Invalid animal type. Please enter animal, dog, or cat.");
        }
      }
    }

   
    Console.WriteLine("Sounds of the animals in the array:");
    for (int i = 0; i < animals.Length; i++)
    {
      animals[i].MakeSound();
    }
  }
}

