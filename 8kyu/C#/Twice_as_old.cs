// Your function takes two arguments:

// current father's age (years)
// current age of his son (years)
// Сalculate how many years ago the father was twice as old as his son (or in how many years he will be twice as old). The answer is always greater or equal to 0, no matter if it was in the past or it is in the future.

using System;

namespace Solution
{
  public class TwiceAsOldSolution
  {
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        //half dadYears rounded down
       int count = 0;
       int doubleSon = sonYears *2;
     
       if(dadYears > doubleSon)
       {
         while (dadYears > doubleSon)
         {
            dadYears--;
            sonYears--;
            count++;
         }
         return count;
       }
       else if(dadYears < doubleSon)
       {
         while (dadYears < doubleSon)
         {
            dadYears++;
            sonYears++;
            count++;
         }
         return count;
       }
       else {
         return 0;
       }
    }
  }
}