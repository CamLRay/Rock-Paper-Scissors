using System;
using RPS;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Rock, Paper, Scissors!");
    Console.WriteLine("How many Players?!");
    int numberOfPlayers = int.Parse(Console.ReadLine());
    if (numberOfPlayers == 2)
    {
      Console.WriteLine("Player 1: Pick");
      string userOneInput = Console.ReadLine();
      Console.WriteLine("Player 2: Pick");
      string userTwoInput = Console.ReadLine();
      RockPS game = new RockPS(userOneInput, userTwoInput);
      string result = game.CompareInputs();
      Console.WriteLine(result);
    } else
    {
      Console.WriteLine("Player: Pick");
      string userOneInput = Console.ReadLine();
      string computer = RockPS.ComputerInput();
      RockPS game = new RockPS(userOneInput, computer);
      string result = game.CompareInputs();
      Console.WriteLine("Computer chose " + computer);
      Console.WriteLine(result);
    }
  }
}    