using System;
using System.Collections.Generic;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,0,0,4,0,5};
            // int[] arr2 = {1,2,3};
            // string[] t = {"gin","zen","gig","msg"};
            // SelfDividingNumbers.solution(100,122);
            // System.Console.WriteLine(28%1);
            // PerfectNumber.optimalsolution(28);
            // int[] yo = {1,3,2,100,20,10,1};
            // int[] yo2 = {34,4,10,40};
            // List<int> mylist = new List<int>(yo);
            // List<int> mylist2 = new List<int>(yo2);
            // Sorts.MergeSort(mylist2);
            BinarySearchTree tree = new BinarySearchTree();
            tree.insert(9);
            tree.insert(4);
            tree.insert(6);
            tree.insert(20);
            tree.insert(170);
            tree.insert(15);
            tree.insert(1);
            tree.insert(192);
            tree.insert(193);

            //      9
            //   4     20
            // 1   6  15  170

            // tree.BreadthFirstSearch();
            // Queue<TreeNode> myQ = new Queue<TreeNode>();
            // myQ.Enqueue(tree.root);
            // List<int> result = new List<int>();
            // tree.BreadthFirstSearchRecursive(myQ, result);
            // int[] yo = {1,1,1,3,3,2,2,2};
            // MajorityElements.ProblemLevel2(yo);
            TittleToNumber.Solution("ZY");
            System.Console.WriteLine((int)'A');
            RomanToInt.Solution("XVIII");
            Anagram.Solution("anagram","nagaram");
            FirstUniqueLetter.Solution("llleet");
            double rr = 0.9;
            int yoo = (int)rr;
            System.Console.WriteLine(yoo);
        }
    }
}
