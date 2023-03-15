// Complete the solution so that the function will break up camel casing, using a space between words.

// Example
// "camelCasing"  =>  "camel Casing"
// "identifier"   =>  "identifier"
// ""             =>  ""

using System;
using System.Collections.Generic;

public class Kata
{
  public static string BreakCamelCase(string str)
  {   
     List<char> resultList = new List<char>();
    
     for(int i=0; i < str.Length; i++)
     {
       if(char.IsUpper(str[i]))
       {
         resultList.Add(' ');
         resultList.Add(str[i]);
       } 
       else
       {
         resultList.Add(str[i]);
       }       
     }
    string result = new string(resultList.ToArray());
    return result;
  }
}