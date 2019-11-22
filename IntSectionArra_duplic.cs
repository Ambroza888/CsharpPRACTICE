using System;
using System.Collections.Generic;

namespace Zen3
{
  class IntersecArrayDupplycate
  {
    public static int[] intSecArrDupply(int[] a, int[] b)
    {
      if (a.Length == 0 || b.Length==0)
      {
        return new int[]{};
      }
      List<int> result = new List<int>();
      Dictionary <int,int> dict = new Dictionary<int, int>();
      
      for (int i = 0; i < a.Length; i++)
      {
        if (!dict.ContainsKey(a[i]))
        {
          dict.Add(a[i], 1);
        } else{
          dict[a[i]]++;
        }
      }

      for (int j = 0; j < b.Length;j++)
      {
        if (dict.ContainsKey(b[j]))
        {
          result.Add(b[j]);
          dict[b[j]] --;
          if (dict[b[j]] == 0)
          {
            dict.Remove(b[j]);
          }
        }
      }
      foreach(var r in result){Console.WriteLine(r);}
      return result.ToArray();
    }
  }
}
