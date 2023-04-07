using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms
{
    /*
     977. Squares of a Sorted Array

    Given an integer array nums sorted in non-decreasing order,
    return an array of the squares of each number sorted in
    non-decreasing order.
     */
    public class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            SortedArray

            SortedSet<int> sortedSquares = new SortedSet<int>();

            foreach (int n in nums)
            {
                sortedSquares.Add(n * n);
            }

            return sortedSquares.ToArray();
        }
    }
}
