using System;
using System.Collections.Generic;

namespace Csharp
{
  class recurent_character
  {
    // Given an array = [2,5,1,2,3,5,1,2,4] output = 2;
    // given an array = [2,1,1,2,3,5,1,2,4] output = 1; should return first repeated character;
    public static void Good(int[] nums)
    {
      Dictionary<int,int> dict = new Dictionary<int, int>();
      for (int i = 0; i < nums.Length;i ++)
      {
        if (!dict.ContainsKey(nums[i]))
        {
          dict.Add(nums[i], 1);
        }
        else
        {
            dict[nums[i]]++;
            if (dict.ContainsValue(2))
            {
              System.Console.WriteLine(nums[i]);            
            }
        }
      }
    }
    public static int Naive(int[] nums)
    {
      for(int i = 0; i < nums.Length-1;i ++)
      {
        for(int j = i+1 ; j < nums.Length;j++)
        {
          if (nums[i] == nums[j])
          {
            return nums[j];
          }
        }
      }
      return 0000;
    } 
    public static int setversion(int[] nums)
    {
      HashSet<int> myset = new HashSet<int>();
      for(int i = 0; i < nums.Length;i++)
      {
        if(!myset.Contains(nums[i]))
        {
          myset.Add(nums[i]);
        } else{
          return nums[i];
        }
      }
      return 0000;
    }
  }
}