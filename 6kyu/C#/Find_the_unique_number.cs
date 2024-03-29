// There is an array with some numbers. All numbers are equal except for one. Try to find it!

// findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
// findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
// It’s guaranteed that array contains at least 3 numbers.

// The tests contain some very huge arrays, so think about performance.

// This is the first kata in series:

// Find the unique number (this kata)
// Find the unique string
// Find The Unique

using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    for(int i=1; i < numbers.Count()-1; i++)
    {
      if(numbers.ElementAt(0) != numbers.ElementAt(i))
      {
        if(numbers.ElementAt(0) != numbers.ElementAt(i+1)){
          return numbers.ElementAt(0);
        } 
        return numbers.ElementAt(i);
      }
    }
    return numbers.ElementAt(numbers.Count()-1);
  }
}