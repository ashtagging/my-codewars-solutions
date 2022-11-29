// Given an array of integers, return a new array with each value doubled.

// For example:

// [1, 2, 3] --> [2, 4, 6]

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] Maps(int[] x)
  {
    return x.Select(i => i*2).ToArray();
  }
}