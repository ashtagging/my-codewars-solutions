// Write Number in Expanded Form
// You will be given a number and you will need to return it as a string in Expanded Form. For example:

// Kata.ExpandedForm(12); # Should return "10 + 2"
// Kata.ExpandedForm(42); # Should return "40 + 2"
// Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"
// NOTE: All numbers will be whole numbers greater than 0.

// If you liked this kata, check out part 2!!

using System;
using System.Collections.Generic;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
        string numStr = num.ToString(); // convert long to string
        List<string> parts = new List<string>();
        for (int i = 0; i < numStr.Length; i++)
        {
            if (numStr[i] != '0')
            {
                string currentNum = numStr[i].ToString();
                currentNum = currentNum.PadRight(numStr.Length - i, '0');
                parts.Add(currentNum);
            }
        }
        return string.Join(" + ", parts);
    }
}