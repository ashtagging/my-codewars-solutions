// There was a test in your class and you passed it. Congratulations!
// But you're an ambitious person. You want to know if you're better than the average student in your class.

// You receive an array with your peers' test scores. Now calculate the average and compare your score!

// Return True if you're better, else False!

// Note:
// Your points are not included in the array of your class's points. For calculating the average point you may add your point to the given array!

using System;

public class Kata
{
  public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
  {
    var total = 0;
    for(int i=0; i<ClassPoints.Length; i++){
      total += ClassPoints[i];
    }
    total = total + YourPoints;
    var average = total/(ClassPoints.Length);
    Console.WriteLine(average);
    Console.WriteLine(YourPoints);
    return YourPoints >= average;
  }
}