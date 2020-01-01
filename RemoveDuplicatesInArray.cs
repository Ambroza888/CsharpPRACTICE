using System;
using System.Collections.Generic;

namespace Csharp
{
  class RemoveDuplicates
  {
    public static int Solution(int[] nums)
    {
      int n = nums.Length;
      if(n == 0) return 0;

      int resultIndex = 0;

      for(int i = 1; i < n ; i++)
      {
        if(nums[i - 1] == nums[i]) continue;

        resultIndex++;
        nums[resultIndex] = nums[i];
      }
      return resultIndex +1;
    }
  }
}