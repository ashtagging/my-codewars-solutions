// Given an array of integers.

// Return an array, where the first element is the count of positives numbers and the second element is sum of negative numbers. 0 is neither positive nor negative.

// If the input is an empty array or is null, return an empty array.

// Example
// For input [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15], you should return [10, -65].

using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
      int pCount = 0;
      int nCount= 0;
      
      if (input == null || input.Length == 0) {
        return new int[] { };
      } else {
          foreach(int num in input){
            if(num>0){
            pCount++;
          } else if(num<0){
            nCount += num;
          }
        }
        int[] numbers = new int[]{pCount,nCount};
        return numbers; 
      }
    }
}