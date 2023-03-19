// Given a string str, reverse it and omit all non-alphabetic characters.

// Example
// For str = "krishan", the output should be "nahsirk".

// For str = "ultr53o?n", the output should be "nortlu".

// Input/Output
// [input] string str
// A string consists of lowercase latin letters, digits and symbols.

// [output] a string

namespace myjinxin
{
    using System;
    using System.Text.RegularExpressions;
    
    public class Kata
    {
        public string ReverseLetter(string str){
          
          string stringWithoutNumbers = Regex.Replace(str, @"[^a-zA-Z]+", "");
          char[] reverse = stringWithoutNumbers.ToCharArray();
          Array.Reverse(reverse);
          
          string result = new String(reverse);
          
          return result;       
        }
    }
}