// An isogram is a word that has no repeating letters, consecutive or non-consecutive. Implement a function that determines whether a string that contains only letters is an isogram. Assume the empty string is an isogram. Ignore letter case.

// Example: (Input --> Output)

// "Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool IsIsogram(string str) 
  {
    char[] charArray = str.ToLower().ToCharArray();
    for(int i=0; i < charArray.Length; i++){
      for(int j= i+1; j < charArray.Length; j++){
        Console.WriteLine((i,j));
        if(charArray[i]==charArray[j]){
          return false;
        }
      }
    }   
    return true; 
   }
}