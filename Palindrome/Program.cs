using System; 
using Palindrome;

public class User 
{
  static void Main()
  {
    Backwards firstBackwards = new Backwards();
    Console.WriteLine("Enter a word, sucker");
    string input = Console.ReadLine().ToLower();
    string reversed = firstBackwards.ReverseOriginalInput(input);
    if(firstBackwards.CompareInputs(input, reversed))
    {
      Console.WriteLine("This is a palindrome");
    }
    else
    {
      Console.WriteLine("This is NOT a palindrome");
    }
  Main();
  }
}