using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp
{
  class MajorityElements
  {
    public static int ProblemLevel1(int[] arr)
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
    public static IList<int> ProblemLevel2(int[] arr)
    {
      List<int> result = new List<int>();

      if(arr.Length == 0) return result;

      int majority = arr.Length/3;

      Dictionary<int,int> count = new Dictionary<int, int>();
      foreach(int i in arr)
      {
        if(count.ContainsKey(i))
        {
          count[i]++;
        }
        else
        {
            count.Add(i, 1);
        }
      }
      foreach(KeyValuePair<int,int> pair in count)
      {
        if(pair.Value > majority)
        {
          result.Add(pair.Key);
        }
      }
      return result;
    }
  }
}