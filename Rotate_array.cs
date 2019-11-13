using System;
using System.Collections.Generic;

namespace Csharp
{
  class RotateArray
  {
    public static void brute(int[] nums, int k)
    {
      int temp, previus;
      for (int i = 0 ; i < k; i++)
      {
        previus = nums[nums.Length-1];
        for ( int j = 0; j < nums.Length; j++)
        {
          temp = nums[j];
          nums[j] = previus;
          previus = temp;
        }
      }
    }
    public static void good(int[] nums, int k)
    {
      int[] result = new int[nums.Length];
      int n = nums.Length;
      for(int i = 0; i < n ; i++)
      {
        result[(i+k)%n] = nums[i];
      }
      for(int j = 0 ; j < n ; j++)
      {
        nums[j] = result[j];
      }
    }
  }
}