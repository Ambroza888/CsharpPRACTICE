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

    public static void mergecheck(int[] nums1, int m, int[] nums2, int n)
    {
      int len = m + n -1;
      m -= 1;
      n -= 1;
      for(int i = len; i >= 0; i --)
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
        else if (m >= 0) 
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
    public static void MergeSortedArrayWhileLoops(int[] nums1, int m, int[] nums2, int n)
    {
      // input:
      //nums1 = [1,2,3,0,0,0], m = 3
      //nums2 = [2,5,6],       n = 3
      //output: [1,2,2,3,4,5,6]


      int i = m + n -1;
      m -= 1;
      m -= 1;
      while(m >= 0 && n >= 0)
      {
        if(nums1[m] > nums2[n])
        {
          nums1[i] = nums1[m];
          i--;
          m--;
        }
        else
        {
            nums1[i] = nums2[n];
            n--;
            i--;
        }
        while(m >= 0)
        {
          nums1[i] = nums1[m];
          m--;
          i--;
        }
        while(n >= 0)
        {
          nums1[i] = nums2[n];
          n--;
          i--;
        }
      }

    }
  }
}