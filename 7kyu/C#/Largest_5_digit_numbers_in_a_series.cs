// In the following 6 digit number:

// 283910
// 91 is the greatest sequence of 2 consecutive digits.

// In the following 10 digit number:

// 1234567890
// 67890 is the greatest sequence of 5 consecutive digits.

// Complete the solution so that it returns the greatest sequence of five consecutive digits found within the number given. The number will be passed in as a string of only digits. It should return a five digit integer. The number passed may be as large as 1000 digits.

// Adapted from ProjectEuler.net

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata 
{
  public static int GetNumber(string str){
 
    List<string> numlist = new List<string>();

    for(int i = 0; i < ((str.Length) - 4); i++){
      string pos1 = (str[i]).ToString();
      string pos2 = (str[i + 1]).ToString();    
      string pos3 = (str[i + 2]).ToString();
      string pos4 = (str[i + 3]).ToString();
      string pos5 = (str[i + 4]).ToString();
      string num = pos1 + pos2 + pos3 + pos4 + pos5;
      
      numlist.Add(num);
    }
  
    return numlist.Max(n => int.Parse(n));
  }
}