// Create a function that takes a Roman numeral as its argument and returns its value as a numeric decimal integer. You don't need to validate the form of the Roman numeral.

// Modern Roman numerals are written by expressing each decimal digit of the number to be encoded separately, starting with the leftmost digit and skipping any 0s. So 1990 is rendered "MCMXC" (1000 = M, 900 = CM, 90 = XC) and 2008 is rendered "MMVIII" (2000 = MM, 8 = VIII). The Roman numeral for 1666, "MDCLXVI", uses each letter in descending order.

// Example:

// RomanDecode.Solution("XXI") -- should return 21
// Help:

// Symbol    Value
// I          1
// V          5
// X          10
// L          50
// C          100
// D          500
// M          1,000

using System;

public class RomanDecode
{
	public static int Solution(string roman)
	{
		string[] symbols = {"I", "V", "X", "L", "C", "D", "M"};
    int[] values = {1, 5, 10, 50, 100, 500, 1000};
    
    int result = 0;
    
		for (int i = 0; i < roman.Length; i++)
		{
			int currentSymbolValue = values[Array.IndexOf(symbols, roman[i].ToString())];
			
			if (i < roman.Length - 1 && currentSymbolValue < values[Array.IndexOf(symbols, roman[i+1].ToString())])
			{
				result -= currentSymbolValue;
			}
			else
			{
				result += currentSymbolValue;
			}
		}
        
    return result;
	}
}