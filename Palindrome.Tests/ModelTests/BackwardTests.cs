using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.Tests
{
  [TestClass]
  public class BackwardsTests
  {
    [TestMethod]
    public void ReverseInput_TakesUserInput_True()
    {
      Backwards testInput = new Backwards();
      Assert.AreEqual(true, testInput.ReverseInput("string"));
    }
    [TestMethod]
    public void ReverseOriginalInput_ReverseInputToOriginal_ReversedWord()
    { 
      Backwards testWord = new Backwards();
      string test = "gnirts";
      Assert.AreEqual(test, testWord.ReverseOriginalInput("string"));
    }
    [TestMethod]
    public void CompareInputs_ComparesInputAndReversedInput_False()
    {
      Backwards newWord = new Backwards();
      Assert.AreEqual(false, newWord.CompareInputs("string", "gnirts"));
    }
  }
}



