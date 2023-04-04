// Given a string, you have to return a string in which each character (case-sensitive) is repeated once.

// Examples (Input -> Output):
// * "String"      -> "SSttrriinngg"
// * "Hello World" -> "HHeelllloo  WWoorrlldd"
// * "1234!_ "     -> "11223344!!__  "

using System.Collections.Generic;

public class Kata
{
  public static string DoubleChar(string s)
  {
    List<char> result = new List<char>();
    
    foreach(char c in s)
    {
      result.Add(c);
      result.Add(c);
    }
    
    return new string(result.ToArray());
  }
}