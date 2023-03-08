// Implement the function unique_in_order which takes as argument a sequence and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.

// For example:

// uniqueInOrder("AAAABBBCCDAABBB") == {'A', 'B', 'C', 'D', 'A', 'B'}
// uniqueInOrder("ABBCcAD")         == {'A', 'B', 'C', 'c', 'A', 'D'}
// uniqueInOrder([1,2,2,3,3])       == {1,2,3}


using System.Collections.Generic;
using System;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
        List<T> result = new List<T>();

        for (int i = 0; i < iterable.Count() - 1; i++)
        {
            if (!iterable.ElementAt(i).Equals(iterable.ElementAt(i + 1)))
            {
                result.Add(iterable.ElementAt(i));
            }
        }

        if (iterable.Any())
        {
            result.Add(iterable.Last());
        }

        return result;
  }
}