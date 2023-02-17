// Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.

// For example (Input --> Output):

// 39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
// 999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
// 4 --> 0 (because 4 is already a one-digit number)

using System;

public class Persist 
{
	public static int Persistence(long n) 
	{
    int result = 0;
    int product = 1;
    
		while(n > 9){
      string num = n.ToString();
      for (int i = 0; i < num.Length; i++)
      {
          int digit = int.Parse(num[i].ToString());
          product *= digit;
      }
      
      n = product;
      product = 1;
      result ++;
    }
    return result;
	}
}