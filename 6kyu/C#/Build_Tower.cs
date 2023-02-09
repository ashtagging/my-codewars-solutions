// Build Tower
// Build a pyramid-shaped tower, as an array/list of strings, given a positive integer number of floors. A tower block is represented with "*" character.

// For example, a tower with 3 floors looks like this:

// [
//   "  *  ",
//   " *** ", 
//   "*****"
// ]
// And a tower with 6 floors looks like this:

// [
//   "     *     ", 
//   "    ***    ", 
//   "   *****   ", 
//   "  *******  ", 
//   " ********* ", 
//   "***********"
// ]
// Go challenge Build Tower Advanced once you have finished this :)

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text; 

public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {  
        List<string> tower = new List<string>();
        for (int i = 0; i < nFloors; i++)
        {
            int space = nFloors - i - 1;
            int stars = 2 * i + 1;
            tower.Add(new string(' ', space) + new string('*', stars) + new string(' ', space));
        }
        return tower.ToArray();
  }
}