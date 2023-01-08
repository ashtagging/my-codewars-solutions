// Sum all the numbers of a given array ( cq. list ), except the highest and the lowest element ( by value, not by index! ).

// The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

// Mind the input validation.

// Example
// { 6, 2, 1, 8, 10 } => 16
// { 1, 1, 11, 2, 3 } => 6
// Input validation
// If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a list with only 1 element, return 0.

using System;
using System.Linq;

public static class Kata
{
  public static int Sum(int[] numbers)
  {
    if(numbers == null) return 0;
    if(numbers.Length == 1 || numbers.Length == 0) return 0;
    
    Array.Sort(numbers);
    int nl = numbers.Length;
    numbers[0] = 0;
    numbers[nl-1] = 0;
    
    return numbers.Sum();
  }
}