using  System;
using System.Collections.Generic;

namespace Csharp
{
  class Move0
  {
    //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //Input: [0,1,0,3,12]
    //Output: [1,3,12,0,0]
    // Input: [0,1,0,3,12] => Output: [1,3,12,0,0];
    public static void MoveZero(int[] nums)
    {
      int zero = 0;
      for(int i = 0; i < nums.Length;i++)
      {
        if ( nums[i] != 0)
        {
          if(zero != i)
          {
            nums[zero] = nums[i];
            nums[i] = 0;
          }
          zero++;
        }
      }
    }
    public static void MoveZero2(int [] nums)
    {
      int n = nums.Length;
      int zeroIndex = 0;
      for(int i = 0; i < n; i++)
      {
        if(nums[i] != 0)
        {
          int temp = nums[i];
          nums[i] = nums[zeroIndex];
          nums[zeroIndex] = temp;
          zeroIndex ++;
        }
      }
    }
  }
}