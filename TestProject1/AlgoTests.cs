using Algorithms;
using System;
using Xunit;


namespace TestProject1
{
    public class AlgoTests
    {
        [Fact]
        public static void SortedSquares()
        {
            //arrange
            int[] array = new int[] { -6, -3, 0, 2, 4, 7 };
            int[] respones = new int[] { 0, 4, 9, 16, 36, 49 };
            //act
            var res = ArraySortProblems.SortedSquares(array);

            //assert

            Assert.Equal(respones, res);
        }

        [Fact]
        public static void ShiftedBinarySearch()
        {
            int[] array = new int[] { 8, 9, 0, 2, 4, 7 };
            var response = ArraySearchProblems.ShiftedBinarySearch(array, 0);

            Assert.Equal(2, response);
        }
    }
}
