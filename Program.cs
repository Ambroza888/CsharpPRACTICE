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
            // tree.insert(9);
            // tree.insert(4);
            // tree.insert(6);
            // tree.insert(20);
            // tree.insert(170);
            // tree.insert(15);
            // tree.insert(1);
            // tree.insert(192);
            // tree.insert(193);
            tree.insert(1);
            tree.insert(2);
            tree.insert(2);
            tree.insert(3);
            tree.insert(4);
            tree.insert(4);
            tree.insert(3);
            SymmetricTree.Solution(tree.root);
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
            // TittleToNumber.Solution("ZY");
            // System.Console.WriteLine((int)'A');
            // RomanToInt.Solution("XVIII");
            // Anagram.Solution("anagram","nagaram");
            // FirstUniqueLetter.Solution("llleet");
            // int[] yo = {0,1,2,3};
            // // MissingNumber.MissingN(yo);
            // HappyNumber.HappyN(19);
            // PascalsTriangle.Solution(5);
            // Climbing_Stairs.Solution(5);
            int[] check = {0,0,1,1,1,2,2,3,3,4};
            PlusOne.Solution(check);
            char[] a = {'a','b','c','d'};
            char[] b = {'e','h','f','q'};

            Contain_common_item.Solution2(a,b);
            RemoveDuplicates.Solution(check);
            TrailingZeroes.Solution(5);
            
        }
    }
}
