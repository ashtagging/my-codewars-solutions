// Given an array of integers as strings and numbers, return the sum of the array values as if all were numbers.

// Return your answer as a number.

using System;

public class Kata
{
  public static int SumMix(object[] x)
  {
    int total = 0;
    foreach(object y in x){
      total += Convert.ToInt32(y);
    }
    return total;
  }
}