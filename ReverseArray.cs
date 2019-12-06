using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class ReverseArray
  {
    public static void Reverse1(int[] arr)
    {
      Array.Reverse(arr);
    }
    public static void Reverse2(int[] arr)
    {
      int n = arr.Length-1;
      int[] result = new int[arr.Length];
      int j = 0;
      for(int i = n; i >= 0; i--)
      {
        result[j] = arr[i];
        j++;
      }
    }
    public static void Reverse3(int[] arr)
    {
      int n = arr.Length-1 ;
      int temp;
      for(int i = 0; i < arr.Length/2;i++)
      {
        temp = arr[i];
        arr[i] = arr[n-i];
        arr[n-i] = temp;
      }
    }
  }
}