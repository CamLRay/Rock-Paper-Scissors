using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPS;

namespace RPS.Tests
{
  [TestClass]
  public class RockPSTests
  {
    [TestMethod]
    public void RockPS_ConstructsGame_strings()
    {
      string userOneInput = "rock";
      string userTwoInput = "rock";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      // Assert
    
    Assert.AreEqual(game.PlayerOne, userOneInput);
    }

    [TestMethod]
    public void CompareInputs_CheckForDraw_String()
    {
      string userOneInput = "rock";
      string userTwoInput = "rock";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Draw", result);
    }
    
    [TestMethod]
    public void CompareInputs_CheckForWinner_String()
    {
      string userOneInput = "rock";
      string userTwoInput = "paper";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 2", result);
    }
    
    [TestMethod]
    public void CompareInputs_CheckForWinner1_String()
    {
      string userOneInput = "paper";
      string userTwoInput = "rock";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 1", result);
    }
    [TestMethod]
    public void CompareInputs_CheckForWinner3_String()
    {
      string userOneInput = "paper";
      string userTwoInput = "scissors";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 2", result);
    }
    [TestMethod]
    public void CompareInputs_CheckForWinner4_String()
    {
      string userOneInput = "scissors";
      string userTwoInput = "paper";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 1", result);
    }
    [TestMethod]
    public void CompareInputs_CheckForWinner5_String()
    {
      string userOneInput = "scissors";
      string userTwoInput = "rock";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 2", result);
    }
     [TestMethod]
    public void CompareInputs_CheckForWinner6_String()
    {
      string userOneInput = "rock";
      string userTwoInput = "scissors";
      RockPS game = new RockPS(userOneInput, userTwoInput);
      // Act
      string result = game.CompareInputs();
      // Assert
    
    Assert.AreEqual("Winner Player 1", result);
    }
  }
}