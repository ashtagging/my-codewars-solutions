// Write function RemoveExclamationMarks which removes all exclamation marks from a given string.

using System.Text.RegularExpressions;  

public class Kata
{
  public static string RemoveExclamationMarks(string s)
  {
    // My Solution:
    return Regex.Replace(s, @"[!]","");

    // A better solution
    // return s.Replace("!", "");
  }
}




