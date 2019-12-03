using System;
using System.Text;
using System.Collections.Generic;

namespace Csharp
{
  class Sorts
  {

    public static void BubbleSort(int[] arr)
    // O(n^2) nested forloop
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
      // O(n^2) nested forloop
      for(int i = 0; i < arr.Length;i++)
      {
        int min = i;
        int temp = arr[i];
        for(int j = i+1; j< arr.Length;j++)
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
    public static void InsertionSort(int[] arr)
    {
      int j, temp;
      for(int i = 1; i <= arr.Length-1;i++)
      {
        temp = arr[i];
        j = i-1;
        while(j >= 0 && arr[j] > temp)
        {
          arr[j + 1] = arr[j];
          j--;
        }
        arr[j + 1] = temp;
      }
    }

    // Merge Sort Divide and Conquer
    // first i will create Mid index on which i will be spliting the beggining and end of the array.
    // left ---> mid <----- right and keep doing that till get to One element in the array(recursion down to count === 1).
    // lets do it.
    public static List<int> MergeSort(List<int> unsorted)
    {
      if(unsorted.Count <= 1)
      {
        return unsorted;
      } 
      List<int> left = new List<int>();
      List<int> right = new List<int>();

      int mid = unsorted.Count/2;

      for(int i = 0;i < mid; i ++) left.Add(unsorted[i]);
      for(int i = mid; i < unsorted.Count; i ++) right.Add(unsorted[i]);

      left = MergeSort(left);
      right = MergeSort(right);
      return Merge(left,right);
    }

    public static List<int> Merge(List<int> left, List<int> right)
    {
      
    }
  }
}