// Return the number (count) of vowels in the given string.

// We will consider a, e, i, o, u as vowels for this Kata (but not y).

// The input string will only consist of lower case letters and/or spaces.

using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
      
        char[] charArray = str.ToLower().ToCharArray();
      
        foreach(char ch in charArray){
          if(ch == 'a' || ch == 'e' || ch == 'i'|| ch == 'o'|| ch == 'u')
          {
            vowelCount+=1;
          }
        }

        return vowelCount;
    }
}