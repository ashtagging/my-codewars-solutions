// Write a function that returns the total surface area and volume of a box as an array: [area, volume]

using System;

    public class Kata
    {
        public static int[] Get_size(int w,int h,int d)
        {            
            var surfaceArea = 2 * (w * h + w * d + h * d);
            var volume = w * h * d;
            return new[] { surfaceArea, volume };
        }
    }