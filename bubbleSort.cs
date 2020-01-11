using System;
using System.Collections.Generic;

namespace Csharp
{
  class BubbleSort
  {
    public static int[] Solution(int[] arr)
    {
      int length = arr.Length;
      for(int i =0 ; i < length; i ++)
      {
        for(int j = 0; j < length-1; j++)
        {
          if(arr[j] > arr[j+1])
          {
            int temp = arr[j+1];
            arr[j+1] = arr[j];
            arr[j] = temp;
          }
        }
      }
      return arr;
    }
  }
}