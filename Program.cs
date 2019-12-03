using System;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = {1,2,3,4,5,6,7,10,8};
            // int[] arr2 = {1,2,3};
            // string[] t = {"gin","zen","gig","msg"};
            // SelfDividingNumbers.solution(100,122);
            // System.Console.WriteLine(28%1);
            // PerfectNumber.optimalsolution(28);
            int[] yo = {1,3,2,100,20,10,1};
            int[] yo2 = {34,4,10,40};
            List<int> mylist = new List<int>(yo);
            List<int> mylist2 = new List<int>(yo2);
            Sorts.MergeSort(mylist);
        }
    }
}
