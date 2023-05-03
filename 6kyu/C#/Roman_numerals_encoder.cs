// Create a function taking a positive integer between 1 and 3999 (both included) as its parameter and returning a string containing the Roman Numeral representation of that integer.

// Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero. In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 1666 uses each Roman symbol in descending order: MDCLXVI.

// Example:

// RomanConvert.Solution(1000) -- should return "M"
// Help:

// Symbol    Value
// I          1
// V          5
// X          10
// L          50
// C          100
// D          500
// M          1,000
// Remember that there can't be more than 3 identical symbols in a row.

// More about roman numerals - http://en.wikipedia.org/wiki/Roman_numerals

using System;

public class RomanConvert
{
	public static string Solution(int n)
    {
        string romanNumeral = "";
        
        // Check if input is within valid range
        if (n < 1 || n > 3999)
        {
            return "";
        }
    
        // Thousands digit
        while (n >= 1000)
        {
            romanNumeral += "M";
            n -= 1000;
        }
    
        // Hundreds digit
        if (n >= 900)
        {
            romanNumeral += "CM";
            n -= 900;
        }
        else if (n >= 500)
        {
            romanNumeral += "D";
            n -= 500;
        }
        else if (n >= 400)
        {
            romanNumeral += "CD";
            n -= 400;
        }
        while (n >= 100)
        {
            romanNumeral += "C";
            n -= 100;
        }
    
        // Tens digit
        if (n >= 90)
        {
            romanNumeral += "XC";
            n -= 90;
        }
        else if (n >= 50)
        {
            romanNumeral += "L";
            n -= 50;
        }
        else if (n >= 40)
        {
            romanNumeral += "XL";
            n -= 40;
        }
        while (n >= 10)
        {
            romanNumeral += "X";
            n -= 10;
        }
    
        // Units digit
        if (n >= 9)
        {
            romanNumeral += "IX";
            n -= 9;
        }
        else if (n >= 5)
        {
            romanNumeral += "V";
            n -= 5;
        }
        else if (n >= 4)
        {
            romanNumeral += "IV";
            n -= 4;
        }
        while (n >= 1)
        {
            romanNumeral += "I";
            n -= 1;
        }
    
        return romanNumeral;
    }    	
}
