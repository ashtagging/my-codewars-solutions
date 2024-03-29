// Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

// Kata.MoveZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}) => new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}

using System.Collections.Generic;

public class Kata
{
  public static int[] MoveZeroes(int[] arr)
  {
    List<int> numList = new List<int>();
    int zeroCount = 0;
    
    for(int i = 0; i < arr.Length ;i++)
    {
      if(arr[i] != 0)
      {
        numList.Add(arr[i]);
      }
      else{
        zeroCount++;
      }     
    }
    
    for(int j =0; j < zeroCount; j++)
    {
      numList.Add(0);
    }
    
    return numList.ToArray();
  }
}