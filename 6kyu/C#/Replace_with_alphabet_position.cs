// Welcome.

// In this kata you are required to, given a string, replace every letter with its position in the alphabet.

// If anything in the text isn't a letter, ignore it and don't return it.

// "a" = 1, "b" = 2, etc.

// Example
// Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
// Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" ( as a string )

using System;
using System.Text;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    var result = new StringBuilder();
    foreach (char c in text) {
        if (char.IsLetter(c)) {
            int pos = char.ToLower(c) - 'a' + 1;
            result.Append(pos.ToString() + " ");
        }
    }
    return result.ToString().TrimEnd();
  }
}