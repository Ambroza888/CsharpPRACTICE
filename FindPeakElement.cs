using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class FindPeakElement
  {
    // input: [1,2,3,1] output 2 ==> 3 is a peak element and you fun shuld return index number 2.
    //input [1,2,1,3,5,6,4] ouput: 1 or 5 index;
    public static int solution(int[] nums)
    {
      int n = nums.Length;
      if(n == 1) return 0;
      if(nums[0] > nums[1]) return 0;
      if(nums[n-2] < nums[n-1]) return n-1;

      int start = 0;
      int end = n - 1;
      
      while(start < end)
      {
        int mid = start + (end - start)/2;

        if(nums[mid-1] < nums[mid] && nums[mid] > nums[mid+1])
        {
          return mid;
        }
        else if(nums[mid-1] < nums[mid])
        {
          start = mid + 1;
        }
        else
        {
            end = mid;
        }
      }
      throw new Exception("bla");
    }
  }
}