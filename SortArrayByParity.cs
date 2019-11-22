using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class Sortarray
  {
    // input : [3,1,2,4] == > even first/ odd after output: [2,4,3,1];
    public static int[] sort(int[] A)
    {
      int start = 0;
      int end = A.Length-1;
      while(start < end)
      {
        if(A[start] % 2 == 0)
        {
          start ++;
        }
        else
        {
          int temp = A[start];
          A[start] = A[end];
          A[end] = temp;
          end --;
        }
      }
      return A;

    }
  }
}