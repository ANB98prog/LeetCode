using LeetCode.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public class SquaresOfSquaresTests
    {
        SquaresOfSortedArray ssa = new SquaresOfSortedArray();

        [Fact]
        public void SortedSquaresFact()
        {
            int[] expected = { 0, 1, 9, 16, 100 };
            int[] nums = { -4, -1, 0, 3, 10 };

            var actual = ssa.SortedSquares(nums);

            Assert.Equal(expected, actual);
        }
    }
}
