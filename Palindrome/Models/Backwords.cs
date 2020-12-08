using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class Backwards
  {
    public bool ReverseInput(string input)
    {
      if(input.Length > 0){
        return true;
      } else {
        return false;
      }
  
    }

    public string ReverseOriginalInput(string word)
    {
      char[] letters = word.ToCharArray();
      Array.Reverse(letters);
      string reversedWord = new String(letters);
      return reversedWord;
    }

    public bool CompareInputs(string word, string reversedWord)
    {
      if (word == reversedWord)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }
  
    }
}
