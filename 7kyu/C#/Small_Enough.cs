// You will be given an array and a limit value. You must check that all values in the array are below or equal to the limit value. If they are, return true. Else, return false.

// You can assume all values in the array are numbers.

using System;

public class Kata
{
  public static bool SmallEnough(int[] a, int limit)
  {
    for(int i=0; i < a.Length;i++){
      if(a[i] > limit){      
        return false;
      } 
    }
    return true;
  }
}