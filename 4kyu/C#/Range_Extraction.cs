using System;
using System.Text;

public class RangeExtraction
{
    public static string Extract(int[] args)
    {
        if (args.Length == 0) return "";
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < args.Length; i++)
        {
            int rangeStart = i;
            while (i < args.Length - 1 && args[i] + 1 == args[i + 1])
            {
                i++;
            }

            if (i > rangeStart + 1) 
            {
                result.Append(args[rangeStart] + "-" + args[i]);
            }
            else 
            {
                result.Append(args[rangeStart]);
                if (i > rangeStart)
                {
                    result.Append("," + args[i]);
                }
            }

            if (i < args.Length - 1)
            {
                result.Append(",");
            }
        }
        return result.ToString();
    }
}