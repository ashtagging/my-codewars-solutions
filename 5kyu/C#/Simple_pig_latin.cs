// Move the first letter of each word to the end of it, then add "ay" to the end of the word. Leave punctuation marks untouched.

// Examples
// Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
// Kata.PigIt("Hello world !");     // elloHay orldway !

using System;
using System.Collections.Generic;

public class Kata
{
  public static string PigIt(string str)
  {
    List<string> strList = new List<string>();
    string[] strArray = str.Split(" ");   
    
    for(int i=0; i <strArray.Length; i++)
    { 
      if(strArray[i] != "!")
      {
          strList.Add(strArray[i].Substring(1) + strArray[i][0] + "ay");
      }
      else{
        strList.Add("!");
      }
    }
    
    return String.Join(" ", strList);
  }
}