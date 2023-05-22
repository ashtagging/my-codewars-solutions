// Time to test your basic knowledge in functions! Return the odds from a list:

// [1, 2, 3, 4, 5]  -->  [1, 3, 5]
// [2, 4, 6]        -->  []

using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static List<int> Odds(List<int> values) =>
    values.Where(x => x%2 != 0)
          .ToList();
}

