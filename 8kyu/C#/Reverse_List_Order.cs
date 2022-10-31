// In this kata you will create a function that takes in a list and returns a list with the reverse order.

// Examples (Input -> Output)
// * [1, 2, 3, 4]  -> [4, 3, 2, 1]
// * [9, 2, 0, 7]  -> [7, 0, 2, 9]

using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    List<int> newList = new List<int>();
    foreach(int i in list){
      newList.Add(i);
    }
    newList.Reverse();
    return newList;
  }
}


//Enumerable solution:

// using System.Collections.Generic;
// using System.Linq;

// public class Kata
// {
//   public static List<int> ReverseList(List<int> list)
//   {
//     return Enumerable.Reverse(list).ToList();
//   }
// }