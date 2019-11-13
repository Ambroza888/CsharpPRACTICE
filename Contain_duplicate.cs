using System;
using System.Collections.Generic;

namespace Csharp
{
  class Containduplicate
  {
    public static bool Naive(int[] nums)
    {
      for (int i = 0; i < nums.Length-1;i++)
      {
        for (int j = i+1; j < nums.Length; j++)
        {
          if ( nums[i] == nums[j]) return true;
        }
      }
      return false;
    }
    public static bool good(int[] nums)
    {
      HashSet<int> myset = new HashSet<int>();
      for(int i = 0 ; i < nums.Length;i++)
      {
        if (!myset.Contains(nums[i]))
        {
          myset.Add(nums[i]);
        } 
        else
        {
          return true;
        }
      }
      return false;
    }
  }
}