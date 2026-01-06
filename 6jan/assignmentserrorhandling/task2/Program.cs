using System;

public class CricketMatch
{
  
  public int[] PlayerScores { get; set; }
  public int CurrentIndex { get; set; }

  public CricketMatch()
  {
    PlayerScores = new int[5];
    CurrentIndex = 0;
  }

  public void AddPlayerScore(int score)
  {
    if (score < 0 || score > 50)
    {
      throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
    }

    if (CurrentIndex >= 5)
    {
      throw new InvalidOperationException("Cannot add more than 5 player scores.");
    }

    PlayerScores[CurrentIndex] = score;
    CurrentIndex++;
  }

  public int CalculateTotalScore()
  {
    int total = 0;
    for (int i = 0; i < CurrentIndex; i++)
    {
      total += PlayerScores[i];
    }
    return total;
  }
}

public class Program
{
  public static void Main()
  {
    try
    {
      CricketMatch match = new CricketMatch();

      string input = Console.ReadLine();
      string[] scores = input.Split(' ');

      foreach (string s in scores)
      {
        int score = Convert.ToInt32(s);
        match.AddPlayerScore(score);
      }

      Console.WriteLine(
        $"Total score of the cricket team: {match.CalculateTotalScore()}"
      );
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
    catch (InvalidOperationException ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}
