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
  }
}