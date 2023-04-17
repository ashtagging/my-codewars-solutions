// Kata Task
// I have a cat and a dog.

// I got them at the same time as kitten/puppy. That was humanYears years ago.

// Return their respective ages now as [humanYears,catYears,dogYears]

// NOTES:

// humanYears >= 1
// humanYears are whole numbers only
// Cat Years
// 15 cat years for first year
// +9 cat years for second year
// +4 cat years for each year after that
// Dog Years
// 15 dog years for first year
// +9 dog years for second year
// +5 dog years for each year after that

public class Dinglemouse {

  public static int[] humanYearsCatYearsDogYears(int humanYears) {
    
    int dogYears = 0;
    int catYears = 0;
    if (humanYears >= 3)
    {
      catYears = 24+((humanYears-2)*4);
      dogYears = 24+((humanYears-2)*5);        
    }
    else if(humanYears == 2)
    {
      catYears = dogYears = 24;
    }
    else 
    {
      catYears = dogYears = 15;
    }

    return new int[]{humanYears,catYears,dogYears};
  }
}