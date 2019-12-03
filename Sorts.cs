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
      // recursive call will split the list/array on small arrays all the way down to One element
      // the way down that means i am touching every each element one time so that makes it O(n).
      // going up is more simple operation like O(1).
      //Creating Merge bringing them back to full sorted array i log
      // Tottal time of complexiti O(n log n);
      return Merge(left,right);
    }

    public static List<int> Merge(List<int> left, List<int> right)
    {
      List<int> result = new List<int>();
      int indexleft = 0;
      int indexright = 0;
      int leftLength = left.Count;
      int righLength = right.Count;
      while(indexleft < leftLength && indexright < righLength)
      {
        if(left[indexleft] < right[indexright])
        {
          result.Add(left[indexleft]);
          indexleft++;
        }
        else
        {
            result.Add(right[indexright]);
            indexright++;
        }
      }
      if(indexleft < leftLength)
      {
        while(indexleft< leftLength)
        {
        result.Add(left[indexleft]);
        indexleft++;
        }
      }
      if(indexright < righLength)
      {
        while(indexright < righLength)
        {
        result.Add(right[indexright]);
        indexright++;
        }
      }
      return result;
    }
  }
}