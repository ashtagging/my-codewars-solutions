// Complete the method/function so that it converts dash/underscore delimited words into camel casing. The first word within the output should be capitalized only if the original word was capitalized (known as Upper Camel Case, also often referred to as Pascal case). The next words should be always capitalized.

// Examples
// "the-stealth-warrior" gets converted to "theStealthWarrior"
// "The_Stealth_Warrior" gets converted to "TheStealthWarrior"

using System;
using System.Text;

public class Kata
{
  public static string ToCamelCase(string str)
  {
    StringBuilder sb = new StringBuilder();

    bool capitalizeNext = false;
    foreach (char c in str)
    {
        if (c == '-' || c == '_')
        {
            capitalizeNext = true;
        }
        else
        {
            if (capitalizeNext)
            {
                sb.Append(Char.ToUpper(c));
                capitalizeNext = false;
            }
            else
            {
                sb.Append(c);
            }
        }
    }

    return sb.ToString();
  }
}