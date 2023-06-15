// Given a sequence of numbers, find the largest pair sum in the sequence.

// For example

// [10, 14, 2, 23, 19] -->  42 (= 23 + 19)
// [99, 2, 2, 23, 19]  --> 122 (= 99 + 23)
// Input sequence contains minimum two elements and every element is an integer.

public class Kata
{
  public static int LargestPairSum(int[] numbers)
  {
     int sum = int.MinValue;
       
     for (int i = 0; i < numbers.Length; i++)
     {
       for (int j = i + 1; j < numbers.Length; j++)
       {
         if (numbers[i] + numbers[j] > sum)
         {
           sum = numbers[i] + numbers[j];
         }
       }
     }
    
     return sum;
  }
}