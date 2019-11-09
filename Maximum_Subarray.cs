using System;
using System.Collections.Generic;

namespace Csharp
{
  // input: [-2,1,-3,4,-1,2,1,-5,4] output: 6; explanation: [4,-1,2,1] has largest sum = 6;
  class MaxSubArray
  {
    public static int MaxSubArrayFunc(int[] nums)
    {
      int max = nums[0];
      int curr = 0;
      for(int i = 0; i < nums.Length;i++)
      {
        if(curr < 0) curr = 0;
        curr = curr + nums[i];
        if ( curr > max) max = curr;
      }
      return max;
    }
  }
}