using System;
using System.Collections.Generic;

namespace Csharp
{
  class ProblemsinRoll
  {
    public IList<string> FizBuz(int n) {
        List<string> result = new List<string>();
        if (n < 1) return result;
        for(int i = 1 ; i <=n ; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
                result.Add("FizzBuzz");
            else if (i % 3 == 0)
                result.Add("Fizz");
            else if(i %5 == 0)
                result.Add("Buzz"); 
            else
            {
                result.Add(i.ToString());
            }
        }
        return result;
    }
    //Given a non-empty array of integers, every element appears twice except for one. Find that single one.
    //Input: [4,1,2,1,2]
    //Output: 4
    public static int SingleNumber(int[] nums)
    {
        HashSet<int> set = new HashSet<int>();
        foreach(int n in nums)
        {
            if(!set.Contains(n))
            {
                set.Add(n);
            }
            else
            {
                set.Remove(n);
            }
        }
        foreach(int i in set)
        {
            return i;
        }
        return -1;
    }
  }
}