using System;

namespace RPS
{
  public class RockPS
  {
    public string PlayerOne {get; set;}
    public string PlayerTwo {get; set;}
    public RockPS(string playerOneInput, string playerTwoInput)
    {
      PlayerOne = playerOneInput;
      PlayerTwo = playerTwoInput;
    }

    public static string ComputerInput()
    {
      Random rnd = new Random();
      int random = rnd.Next(3);
      string computer = "";
      switch (random)
      {
        case 0:
          computer = "rock";
          break;
        case 1:
          computer = "paper";
          break;
        case 2:
          computer = "scissors";
          break;
      }
      return computer;
    }
    public string CompareInputs ()
    {
      if (PlayerOne == PlayerTwo)
      {
        return "Draw";
      }
      else if (PlayerOne == "rock" && PlayerTwo == "paper")
      {
        return "Winner Player 2";
      }
      else if (PlayerOne == "paper" && PlayerTwo == "rock")
      {
        return "Winner Player 1";
      }
      else if (PlayerOne == "paper" && PlayerTwo == "scissors")
      {
        return "Winner Player 2";
      }
      else if (PlayerOne == "scissors" && PlayerTwo == "paper")
      {
        return "Winner Player 1";
      }
      else if (PlayerOne == "scissors" && PlayerTwo == "rock")
      {
        return "Winner Player 2";
      }
      else if (PlayerOne == "rock" && PlayerTwo == "scissors")
      {
        return "Winner Player 1";
      }
      else
      {
        return "check more";
      }
    }
  }
}