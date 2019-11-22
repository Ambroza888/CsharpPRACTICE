using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class UniqueNumber
  {
    public static bool solution(int[] arr)
    {
      if(arr == null || arr.Length == 0)
      {
        return true;
      }
      int n = arr.Length;
      Dictionary<int,int> dict = new Dictionary<int, int>();
      for(int i = 0 ; i < n; i ++)
      {
        if (!dict.ContainsKey(arr[i]))
        {
          dict.Add(arr[i],0);
        }
        else
        {
          dict[arr[i]]++;
        }
      }
      HashSet<int> hash = new HashSet<int>();
      foreach(var j in dict)
      {
        if(hash.Contains(j.Value))
        {
          return false;
        }
        else
        {
            hash.Add(j.Value);
        }
      }
      return true;
    }
  }
}