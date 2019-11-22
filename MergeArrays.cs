using System;
using System.Collections.Generic;

namespace Zen3
{
  class MergeArrays
  {
    public static int[] MergeArrayNaive(int[] arr1, int[] arr2)
    {
      if ( arr1.Length == 0)
        return arr2;
      if (arr2.Length == 0)
        return arr1;

      List<int> result = new List<int>();
      int n1 = arr1.Length;
      int n2 = arr2.Length;
      int i = 0;
      int j = 0;

      while(i < n1 && j < n2)
      {
        if(arr1[i] < arr2[j])
        {
          result.Add(arr1[i]);
          i++;
        }
        else
        {
          result.Add(arr2[j]);
          j++;
        }
      }
      if ( i < n1)
      {
        while(i < n1)
        {
          result.Add(arr1[i]);
          i++;
        }
      }
      if (j < n2)
      {
        while (j<n2)
        {
          result.Add(arr2[j]);
          j++;
        }
      }
      foreach(var q in result){System.Console.WriteLine(q);}
      return result.ToArray();
    }
  }
}