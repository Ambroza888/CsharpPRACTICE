using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class MajorityElements
  {
    public static int Solution(int[] arr)
    {
      Dictionary<int,int> counter = new Dictionary<int, int>();
      int majority = arr.Length/2;
      int n = arr.Length;
      for(int i =0 ;i < n;i++)
      {
        if(counter.ContainsKey(arr[i]))
        {
          counter[arr[i]]++;
        }
        else
        {
            counter.Add(arr[i],1);
        }
        if(counter[arr[i]] > majority) return arr[i];
      }
      throw new Exception("no Majority");
    }
  }
}