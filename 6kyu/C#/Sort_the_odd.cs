// Task
// You will be given an array of numbers. You have to sort the odd numbers in ascending order while leaving the even numbers at their original positions.

// Examples
// [7, 1]  =>  [1, 7]
// [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
// [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]

using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] SortArray(int[] array)
  {
    List<int> oddIndexList = new List<int>();
    List<int> oddList = new List<int>();
    
    int[] sortedArray = new int[array.Length];
       
    for(int i=0; i<array.Length;i++)
    {
      if(array[i] % 2 != 0)
      {
        oddIndexList.Add(i);
        oddList.Add(array[i]);
      } else{
        sortedArray[i] = array[i];
      }
    }
    
    oddList.Sort();
    
    for(int j=0; j < oddList.Count; j++)
    {
      sortedArray[oddIndexList[j]] = oddList[j];
    }
    
    return sortedArray;
  }
}