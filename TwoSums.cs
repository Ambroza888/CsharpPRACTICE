using System.Collections.Generic;
using System;
namespace Csharp
{
  // input: [2,7,11,15], target = 9; output : [0,1] explanation : nums[0]  + nums[1] = 2+7 = 9;
  class TwoSum
  {
    public static int[] TwosumO(int[] arr, int target)
    {
      int[] result = new int[2];
      Dictionary<int,int> dict = new Dictionary<int, int>();
      for(int i = 0; i < arr.Length;i++)
      {
        if (dict.ContainsKey(arr[i]))
        {
          result[0] = dict[arr[i]];
          result[1] = i;
          return result;
        }
        dict[target - arr[i]] = i;
      }
      return result;
    }
    public static int[] TwoSumMyCase(int[] nums, int target)
    {
      List<int> result = new List<int>();
      Dictionary<int,int> map = new Dictionary<int, int>();
      for(int i = 0; i < nums.Length; i ++)
      {
        if(map.ContainsKey(nums[i]))
        {
          result.Add(map[nums[i]]);
          result.Add(i);
        }
        map[target-nums[i]] = i;
      }
      return result.ToArray();
    }
    public static int[] TwoSum2(int[] nums,int target)
    {
      List<int> result = new List<int>();
      Dictionary<int,int> map= new Dictionary<int, int>();
      for(int i = 0; i < nums.Length;i++)
      {
        if(map.ContainsKey(nums[i]))
        {
          result.Add(map[nums[i]]);
          result.Add(i);
        }
        map[target-nums[i]] = i;
      }
      foreach(var i in result){Console.WriteLine(i);}
      return result.ToArray();
    }
  }
}