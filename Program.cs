using System;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,10,8};
            int[] arr2 = {1,2,3};
            string[] t = {"gin","zen","gig","msg"};
            BinarySearchTree yo = new BinarySearchTree();
            yo.insert(9);
            yo.insert(4);
            yo.insert(6);
            yo.insert(20);
            yo.insert(170);
            yo.insert(15);
            yo.lookup(170);
            SumSqrtRoot.solution(18);
            ValidParenteses.solution("((()))");

            
        }
    }
}
