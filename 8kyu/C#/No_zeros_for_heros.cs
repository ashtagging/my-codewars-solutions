// Numbers ending with zeros are boring.

// They might be fun in your world, but not here.

// Get rid of them. Only the ending ones.

// 1450 -> 145
// 960000 -> 96
// 1050 -> 105
// -1050 -> -105
// Zero alone is fine, don't worry about it. Poor guy anyway

public class NoBoring 
{
    public static int NoBoringZeros(int n) 
    {
        string nString = n.ToString();
        int nLength = nString.Length; 
        
        for (int i = nLength - 1; i >= 0; i--)
        {
            if (nString[i] == '0')
            {
                nString = nString.Remove(i);
            }
            else 
            {
                return Convert.ToInt32(nString);
            }
        }
        
        return n; 
    }
}