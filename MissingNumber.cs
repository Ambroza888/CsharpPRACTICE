using System;
using System.Collections.Generic;

namespace Csharp
{
  class MissingNumber
  {
    public static int MissingN(int[] nums)
    {
      HashSet<int> myset = new HashSet<int>();

      foreach(int i in nums)
      {
        myset.Add(i);
      }
      int expectedCount = nums.Length+1;
      for(int i = 0 ; i < expectedCount;i++)
      {
        if(!myset.Contains(i))
        {
          return i;
        }
      }
      return -1;
    }
  }
}