using System;
using System.Collections.Generic;

namespace Csharp
{
  class findmaxProduct
  {
    public static int MaxProduct(int[] nums)
    {
      int max = nums[0];

      //iterate from left
      int curr = 1;
      for(int i = 0; i < nums.Length;i++)
      {
        curr = curr* nums[i];

        if(curr > max)
        {
          max = curr;
        }
        if (curr == 0)
        {
          curr = 1;
        }
      }
      // iterate from right
      curr = 1;
      for(int i = nums.Length - 1; i >= 0;i--)
      {
        curr = curr*nums[i];
        if(curr > max)
        {
          max = curr;
        }
        if (curr == 0)
        {
          curr = 1;
        }
      }
      return max;
    }
  }
}