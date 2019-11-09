using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {-2,1,-3,4,-1,2,1,-5,4};
            // TwoSum.TwosumO(arr,9);
            // System.Console.WriteLine(revINT.reverseINT(12345));
            // System.Console.WriteLine(reverseStrDollarSign.reverseSTR("dc,b$a"));
            // TwoSum.TwoSum2(arr,9);
            // ReverseString.ReverseSTR1("Hi My name is Andrei");
            Console.WriteLine(MaxSubArray.MaxSubArrayFunc(arr));
        }
    }
}
