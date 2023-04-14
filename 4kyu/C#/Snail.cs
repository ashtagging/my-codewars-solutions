// Snail Sort
// Given an n x n array, return the array elements arranged from outermost elements to the middle element, traveling clockwise.

// array = [[1,2,3],
//          [4,5,6],
//          [7,8,9]]
// snail(array) #=> [1,2,3,6,9,8,7,4,5]
// For better understanding, please follow the numbers of the next array consecutively:

// array = [[1,2,3],
//          [8,9,4],
//          [7,6,5]]
// snail(array) #=> [1,2,3,4,5,6,7,8,9]
// This image will illustrate things more clearly:


// NOTE: The idea is not sort the elements from the lowest value to the highest; the idea is to traverse the 2-d array in a clockwise snailshell pattern.

// NOTE 2: The 0x0 (empty matrix) is represented as en empty array inside an array [[]].

using System.Collections.Generic;

public class SnailSolution
{
   public static int[] Snail(int[][] array)
   {      
     List<int> result = new List<int>();
     
     int rowBegin = 0;
     int rowEnd = array.Length - 1;
     int colBegin = 0;
     int colEnd = array[0].Length - 1;


     while (rowBegin <= rowEnd && colBegin <= colEnd)
     {
        for (int i = colBegin; i <= colEnd; i++)
        {
            result.Add(array[rowBegin][i]);
        }

        rowBegin++;

        for (int i = rowBegin; i <= rowEnd; i++)
        {
            result.Add(array[i][colEnd]);
        }

        colEnd--;

        if (rowBegin <= rowEnd)
        {
            for (int i = colEnd; i >= colBegin; i--)
            {
                result.Add(array[rowEnd][i]);
            }
        }

        rowEnd--;

        if (colBegin <= colEnd)
        {
            for (int i = rowEnd; i >= rowBegin; i--)
            {
                result.Add(array[i][colBegin]);
            }
        }

        colBegin++;
     }

     return result.ToArray();
   }
}