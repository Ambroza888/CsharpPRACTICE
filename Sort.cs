using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class Sorts
  {
    public static void BubbleSort(int[] arr)
    {
      for(int i = 0; i < arr.Length;i++)
      {
        for(int j = 0; j< arr.Length-1;j++)
        {
          if(arr[j] > arr[j+1])
          {
            int temp = arr[j];
            arr[j] = arr[j+1];
            arr[j+1] = temp;
          }
        }
      }
    }
    public static void SelectionSort(int[] arr)
    {
      for(int i = 0; i < arr.Length;i++)
      {
        int min = i;
        int temp = arr[i];
        for(int j = i+1; j< arr.Length-1;j++)
        {
          if(arr[j] < arr[min])
          {
            min = j; 
          }
        }
      arr[i] = arr[min];
      arr[min] = temp;
      }
    }
  }
}