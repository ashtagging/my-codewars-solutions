// Write simple .camelCase method (camel_case function in PHP, CamelCase in C# or camelCase in Java) for strings. All words must have their first letter capitalized without spaces.

// For instance:

// camelCase("hello case"); // => "HelloCase"
// camelCase("camel case word"); // => "CamelCaseWord"
// Don't forget to rate this kata! Thanks :)

using System.Globalization;

namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return "";
            }

            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            string result = textInfo.ToTitleCase(str).Replace(" ", "");
            return result;
        }
    }
}
