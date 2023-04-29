// Complete the function that takes two integers (a, b, where a < b) and return an array of all integers between the input parameters, including them.

// For example:

// a = 1
// b = 4
// --> [1, 2, 3, 4]

using System.Collections.Generic;

public class Kata {
  public static int[] Between(int a, int b) {
  
    List<int> numList = new List<int>();
    
    for (int i = a; i <= b; i++)
    {
      numList.Add(i);
    }
    
    return numList.ToArray();
  }
}