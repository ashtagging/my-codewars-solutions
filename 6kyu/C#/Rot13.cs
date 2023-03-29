// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13 letters after it in the alphabet. ROT13 is an example of the Caesar cipher.

// Create a function that takes a string and returns the string ciphered with Rot13. If there are numbers or special characters included in the string, they should be returned as they are. Only letters from the latin/english alphabet should be shifted, like in the original Rot13 "implementation".

using System;
using System.Collections.Generic;

public class Kata
{
  public static string Rot13(string message)
  {
    List<char> result = new List<char>();
    
    for (int i = 0; i < message.Length; i++)
    {
      if(message[i] >= 65 && message[i] <= 77)
      {
        result.Add((char)(message[i] + 13));
      }
      else if (message[i] <= 90 && message[i] >= 78)
      {
        result.Add((char)(message[i] - 13));
      }
      else if (message[i] >= 97 && message[i] <= 109)
      {
        result.Add((char)(message[i] + 13));
      }
      else if (message[i] <= 122 && message[i] >= 110)
      {
        result.Add((char)(message[i]-13));
      }
      else
      {
        result.Add(message[i]);
      }
    }
    
    return string.Join("", result);
  }
}