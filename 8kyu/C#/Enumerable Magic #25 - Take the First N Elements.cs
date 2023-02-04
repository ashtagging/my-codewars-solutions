// Create a function that accepts a list/array and a number n, and returns a list/array of the first n elements from the list/array.

// If you need help, here's a reference:

// https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netcore-3.1

using System;
using System.Collections.Generic;

public static class Kata
{
    public static int[] Take(int[] arr, int n)
    {
      
        if(n == 0 || arr.Length == 0) return new int[0];
        if(n > arr.Length) return arr;
      
        List<int> result = new List<int>();
        for(int i =0; i < n;i++){
          result.Add(arr[i]);
        }
          
        return result.ToArray();
    }
}