using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class MergeSortedArray
  {
    public static void MergeSRTARR(int[] nums1, int m, int[] nums2, int n)
    {
      int len = m + n;
      m -= 1;
      n -= 1;
      for(int i = len -1; i >= 0;i--)
      {
        if(m >= 0 && n >= 0)
        {
          if(nums1[m] > nums2[n])
          {
            nums1[i] = nums1[m];
            m--;
          }
          else
          {
              nums1[i] = nums2[n];
              n--;
          }
        }
        else if ( m >= 0)
        {
          nums1[i] = nums1[m];
          m--;
        }
        else 
        {
          nums1[i] = nums2[n];
          n--;
        }
      }
    }
  }
}