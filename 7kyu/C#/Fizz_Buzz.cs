// Return an array containing the numbers from 1 to N, where N is the parametered value.

// Replace certain values however if any of the following conditions are met:

// If the value is a multiple of 3: use the value "Fizz" instead
// If the value is a multiple of 5: use the value "Buzz" instead
// If the value is a multiple of 3 & 5: use the value "FizzBuzz" instead
// N will never be less than 1.

// Method calling example:

// string[] result = FizzBuzz.GetFizzBuzzArray(3); // => [ "1", "2", "Fizz" ]

using System;
using System.Collections.Generic;

public class FizzBuzz
{
	public static string[] GetFizzBuzzArray(int n)
	{
    var result = new List<string>();
    
    for (int i = 1; i <= n; i++)
    {
      if(i % 5 == 0 && i % 3 == 0)
      {
        result.Add("FizzBuzz");
        continue;
      }
      if(i % 3 == 0)
      {
        result.Add("Fizz");
        continue;
      }
      if(i % 5 == 0)
      {
        result.Add("Buzz");
        continue;
      }
      result.Add(i.ToString());
    }
    
    return result.ToArray();
	}
}