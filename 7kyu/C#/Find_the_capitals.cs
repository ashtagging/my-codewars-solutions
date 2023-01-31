// Instructions
// Write a function that takes a single string (word) as argument. The function must return an ordered list containing the indexes of all capital letters in the string.

// Example
// Assert.AreEqual(Kata.Capitals("CodEWaRs"), new int[]{0,3,4,6});

using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static int[] Capitals(string word)
  {
    char[] chars = word.ToCharArray();
    List<int> indexPositions = new List<int>();
        
    for(int i=0; i < chars.Length; i++){
      if(Char.IsUpper(chars[i])){
        indexPositions.Add(i);
      }
    }
    
    return indexPositions.ToArray();
  }
}