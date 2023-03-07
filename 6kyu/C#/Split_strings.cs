// Complete the solution so that it splits the string into pairs of two characters. If the string contains an odd number of characters then it should replace the missing second character of the final pair with an underscore ('_').

// Examples:

// * 'abc' =>  ['ab', 'c_']
// * 'abcdef' => ['ab', 'cd', 'ef']

using System;
using System.Collections.Generic;
using System.Linq;

public class SplitString
{
  public static string[] Solution(string str)
  {
    List<string> stringList = new List<string>();

    for (int i = 0; i < str.Length; i++)
    {
        if (i % 2 == 0)
        {
            if (i < str.Length - 1)
            {
                stringList.Add(str.Substring(i, 2));
            }
            else
            {
                stringList.Add(str.Substring(i, 1) + "_");
            }
        }
    }

    return stringList.ToArray();
  }
}