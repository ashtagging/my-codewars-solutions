// Take an array and remove every second element from the array. Always keep the first element and start removing with the next element.

// Example:
// ["Keep", "Remove", "Keep", "Remove", "Keep", ...] --> ["Keep", "Keep", "Keep", ...]

// None of the arrays will be empty, so you don't have to worry about that!

using System;
using System.Collections.Generic;
using System.Linq;

  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
           List<object> lst = arr.OfType<object>().ToList();
            for(int i= arr.Length -1 ; i>0;i--){
              if(i % 2 == 1){
                lst.RemoveAt(i);
              }
            }
          return lst.ToArray();
        }
    }