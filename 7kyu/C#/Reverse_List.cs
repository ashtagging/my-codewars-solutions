// Write reverseList function that simply reverses lists.

using System;

namespace Solution
{
  public static class Program
  {
    public static int[] reverseList(int[] list)
    {
      Array.Reverse(list);
      return list;
    }
  }
}