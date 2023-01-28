// Description:

// We want to generate a function that computes the series starting from 0 and ending until the given number.

// Example:
// Input:

// > 6
// Output:

// 0+1+2+3+4+5+6 = 21

// Input:

// > -15
// Output:

// -15<0

// Input:

// > 0
// Output:

// 0=0

public class SequenceSum
{
  public static string ShowSequence(int n)
  {  
    if (n < 0) return $"{n}<0";
    if(n == 0) return "0=0";
    
    int total = 0;
    string sequence = "0";
    for(int i = 1; i <= n;i++)
    {
      total += i;
      sequence = sequence + $"+{i}";
    }
    
    return sequence + $" = {total}";
  }
}