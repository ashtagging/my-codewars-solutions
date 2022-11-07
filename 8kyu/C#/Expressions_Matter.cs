// Task
// Given three integers a ,b ,c, return the largest number obtained after inserting the following operators and brackets: +, *, ()
// In other words , try every combination of a,b,c with [*+()] , and return the Maximum Obtained (Read the notes for more detail about it)
// Example
// With the numbers are 1, 2 and 3 , here are some ways of placing signs and brackets:

// 1 * (2 + 3) = 5
// 1 * 2 * 3 = 6
// 1 + 2 * 3 = 7
// (1 + 2) * 3 = 9
// So the maximum value that you can obtain is 9.

// Notes
// The numbers are always positive.
// The numbers are in the range (1  ≤  a, b, c  ≤  10).
// You can use the same operation more than once.
// It's not necessary to place all the signs and brackets.
// Repetition in numbers may occur .
// You cannot swap the operands. For instance, in the given example you cannot get expression (1 + 3) * 2 = 8.


using System.Linq;
using System;

public class Kata
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
      // This Kata is broken as the soloution is incorrect numArray is the correct answer 
      // Edit it states you can't swap the operands
      
      int[] numArray = {a + b + c, a + b * c, a * b + c, a * c + b, a * b * c, a * (b + c), b * (c + a), c * (a + b)};
      int[] theWrongArray = { a * (b + c), a * b * c, a + b * c, (a + b) * c, a + b + c };
      int max = numArray.Max();
      int oldmax = theWrongArray.Max();
      Console.WriteLine(a+b+c);
      Console.WriteLine(a+b*c);
      Console.WriteLine(a*b+c);
      Console.WriteLine(a*c+b);
      Console.WriteLine(a*b*c);
      Console.WriteLine(a*(b+c));
      Console.WriteLine(b*(c+a));
      Console.WriteLine(c*(a+b));
      Console.WriteLine("[{0}]", string.Join(", ", numArray));
      return oldmax;
    }
}